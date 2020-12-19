cmake_minimum_required(VERSION 3.8)

PROJECT(AOC2020 LANGUAGES CSharp)

include(CSharpUtilities)

set(CODE
	Common/ArrayExtension.cs
	Common/IO.cs
	Common/ListExtension.cs
	Common/SolutionClassAttribute.cs
	Common/SolutionMethodAttribute.cs
	Common/SolutionType.cs
	Common/Solver.cs
	Day01/Day01.cs
	Day02/Day02.cs
	Day03/Day03.cs
	Day04/Day04.cs
	Day05/Day05.cs
	Day06/Day06.cs
	Day07/Day07.cs
	Day08/Day08.cs
	Day09/Day09.cs
	Day10/Day10.cs
	Day11/Day11.cs
	Day12/Day12.cs
	Day13/Day13.cs
	Day14/Day14.cs
	Day15/Day15.cs
	Day16/Day16.cs
	Day17/Day17.cs
	Day18/Day18.cs
	Day19/Day19.cs
)

set(RESOURCES
	Day01/Example.txt
	Day01/Input.txt
	Day02/Example.txt
	Day02/Input.txt
	Day03/Example.txt
	Day03/Input.txt
	Day04/Example1.txt
	Day04/Example2.txt
	Day04/Input.txt
	Day05/Input.txt
	Day06/Example.txt
	Day06/Input.txt
	Day07/Example1.txt
	Day07/Example2.txt
	Day07/Input.txt
	Day08/Example.txt
	Day08/Input.txt
	Day09/Example.txt
	Day09/Input.txt
	Day10/Example1.txt
	Day10/Example2.txt
	Day10/Input.txt
	Day11/Example.txt
	Day11/Input.txt
	Day12/Example.txt
	Day12/Input.txt
	Day13/Example.txt
	Day13/Input.txt
	Day14/Example1.txt
	Day14/Example2.txt
	Day14/Input.txt
	Day16/Example1.txt
	Day16/Example2.txt
	Day16/Input.txt
	Day17/Example.txt
	Day17/Input.txt
	Day18/Input.txt
	Day19/Example1.txt
	Day19/Example2.txt
	Day19/Input.txt
)

add_library(Solutions SHARED ${CODE} ${RESOURCES})

SET_SOURCE_FILES_PROPERTIES(${RESOURCES} PROPERTIES VS_TOOL_OVERRIDE "None")
SET_SOURCE_FILES_PROPERTIES(${RESOURCES} PROPERTIES VS_COPY_TO_OUT_DIR "PreserveNewest")

set_property(TARGET Solutions PROPERTY VS_DOTNET_REFERENCES
	"System"
	)

add_executable(AOC2020 Program.cs)
target_link_libraries(AOC2020 Solutions)

set(TEST
	Day01/Test.cs
	Day02/Test.cs
	Day03/Test.cs
	Day04/Test.cs
	Day05/Test.cs
	Day06/Test.cs
	Day07/Test.cs
	Day08/Test.cs
	Day09/Test.cs
	Day10/Test.cs
	Day11/Test.cs
	Day12/Test.cs
	Day13/Test.cs
	Day14/Test.cs
	Day15/Test.cs
	Day16/Test.cs
	Day17/Test.cs
	Day18/Test.cs
	Day19/Test.cs
)

add_library(Tests SHARED ${TEST})

set_target_properties(Tests
	PROPERTIES
	VS_GLOBAL_PROJECT_TYPES "{3AC096D0-A1C2-E12C-1390-A8335801FDAB};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"
)

set_property(TARGET Tests PROPERTY VS_DOTNET_REFERENCES
    "Microsoft.VisualStudio.QualityTools.UnitTestFramework"
	)

target_link_libraries(Tests Solutions)