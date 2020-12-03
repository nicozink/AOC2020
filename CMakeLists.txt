cmake_minimum_required(VERSION 3.8)

PROJECT(AOC2020 LANGUAGES CSharp)

include(CSharpUtilities)

set(CODE
	Common/IO.cs
	Common/ISolution.cs
	Solutions/Day01.cs
	Solutions/Day02.cs
	Solutions/Day03.cs
)

set(RESOURCES
	Input/Day01/Example.txt
	Input/Day01/Input.txt
	Input/Day02/Example.txt
	Input/Day02/Input.txt
	Input/Day03/Example.txt
	Input/Day03/Input.txt
)

add_library(Solutions SHARED ${CODE} ${RESOURCES})

SET_SOURCE_FILES_PROPERTIES(${RESOURCES} PROPERTIES VS_TOOL_OVERRIDE "None")
SET_SOURCE_FILES_PROPERTIES(${RESOURCES} PROPERTIES VS_COPY_TO_OUT_DIR "PreserveNewest")

add_executable(AOC2020 Program.cs)
target_link_libraries(AOC2020 Solutions)

set(TEST
	Tests/Day01Test.cs
	Tests/Day02Test.cs
	Tests/Day03Test.cs
)

add_library(Tests SHARED ${TEST})

set_target_properties(Tests
	PROPERTIES
	VS_GLOBAL_PROJECT_TYPES "{3AC096D0-A1C2-E12C-1390-A8335801FDAB};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"
)

set_property(TARGET Tests PROPERTY VS_DOTNET_REFERENCES
    "Microsoft.VisualStudio.QualityTools.UnitTestFramework")

target_link_libraries(Tests Solutions)