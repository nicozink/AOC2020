cmake_minimum_required(VERSION 3.8)

PROJECT(AOC2020 LANGUAGES CSharp)

include(CSharpUtilities)

set(CODE
	Common/IO.cs
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