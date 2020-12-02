cmake_minimum_required(VERSION 3.8)

PROJECT(AOC2020 LANGUAGES CSharp)

include(CSharpUtilities)

set(CODE
	Common/IO.cs
	Solutions/Day01.cs
	Solutions/Day02.cs
	Program.cs
)

set(RESOURCES
	Input/Day01.txt
	Input/Day02.txt
)

add_executable(AOC2020 ${CODE} ${RESOURCES})

SET_SOURCE_FILES_PROPERTIES(${RESOURCES} PROPERTIES VS_TOOL_OVERRIDE "None")
SET_SOURCE_FILES_PROPERTIES(${RESOURCES} PROPERTIES VS_COPY_TO_OUT_DIR "PreserveNewest")
