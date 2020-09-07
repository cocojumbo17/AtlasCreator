#include <iostream>
#include "finders_interface.h"
#include <fstream>
#include <string>
/* For description of the algorithm, please see the README.md */

using namespace rectpack2D;

bool readRectangles(const std::string& file_name, std::vector<rect_xywh>& rectangles)
{
	std::ifstream f;
	f.open(file_name);
	while (f.good()) 
	{
		int w=0, h=0;
		f >> w >> h;
		if (w > 0 && h > 0)
			rectangles.emplace_back(rect_xywh(0, 0, w, h));
	}
	f.close();

	return !rectangles.empty();
}

int main(int argc, char* argv[]) {
	if (argc != 2)
	{
		std::cout << "Incorrect parameters. Should be:" << std::endl;
		std::cout << "RectPack2D.exe <filename of file with rectangle sizes>." << std::endl;
		std::cout << "Output is size of atlas + list of coordinates of rectangles in the same order." << std::endl;
		return -1;
	}
	const std::string input_file_name(argv[1]);

	std::vector<rect_xywh> rectangles;
	if (!readRectangles(input_file_name, rectangles))
	{
		std::cout << "Incorrect format of input file " << input_file_name << std::endl;
		return -1;
	}



	/* 
		Here, we choose the "empty_spaces" class that the algorithm will use from now on. 
	
		The first template argument is a bool which determines
		if the algorithm will try to flip rectangles to better fit them.

		The second argument is optional and specifies an allocator for the empty spaces.
		The default one just uses a vector to store the spaces.
		You can also pass a "static_empty_spaces<10000>" which will allocate 10000 spaces on the stack,
		possibly improving performance.
	*/

	constexpr bool allow_flip = false;
	const auto runtime_flipping_mode = flipping_option::DISABLED;

	using spaces_type = rectpack2D::empty_spaces<allow_flip, default_empty_spaces>;

	/* 
		rect_xywh or rect_xywhf (see src/rect_structs.h), 
		depending on the value of allow_flip.
	*/
	using rect_type = output_rect_t<spaces_type>;

	/*
		Note: 

		The multiple-bin functionality was removed. 
		This means that it is now up to you what is to be done with unsuccessful insertions.
		You may initialize another search when this happens.
	*/

	auto report_successful = [](rect_type&) {
		return callback_result::CONTINUE_PACKING;
	};

	auto report_unsuccessful = [](rect_type&) {
		return callback_result::CANCEL_PACKING;
	};

	/*
		Initial size for the bin, from which the search begins.
		The result can only be smaller - if it cannot, the algorithm will gracefully fail.
	*/

	const auto max_side = 2000;

	/*
		The search stops when the bin was successfully inserted into,
		AND the next candidate bin size differs from the last successful one by *less* then discard_step.

		See the algorithm section of README for more information.
	*/

	const auto discard_step = 1;

	/* 
		Create some arbitrary rectangles.
		Every subsequent call to the packer library will only read the widths and heights that we now specify,
		and always overwrite the x and y coordinates with calculated results.
	*/


	
	auto report_result = [&rectangles](const rect_wh& result_size) {
		std::cout << result_size.w << " " << result_size.h << std::endl;

		for (const auto& r : rectangles) {
			std::cout << r.x << " " << r.y << std::endl;
		}
	};

	{
		/*
			Example 1: Find best packing with default orders. 

			If you pass no comparators whatsoever, 
			the standard collection of 6 orders:
		   	by area, by perimeter, by bigger side, by width, by height and by "pathological multiplier"
			- will be passed by default.
		*/

		const auto result_size = find_best_packing<spaces_type>(
			rectangles,
			make_finder_input(
				max_side,
				discard_step,
				report_successful,
				report_unsuccessful,
				runtime_flipping_mode
			)
		);

		report_result(result_size);
	}

	return 0;
}
