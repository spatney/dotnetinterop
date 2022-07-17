#!/bin/bash
# quick way to run everything

pushd cpp/lib
cmake .
make -j10
popd
printf "\nRunning Program ...\n\n"
dotnet run 10 20