#!/bin/bash

set -ex

dotnet publish src/ndig.csproj \
	--configuration Release \
	--output build \
	-p:PublishReadyToRun=false \
	-p:PublishSingleFile=true \
	-p:PublishTrimmed=true \
	--self-contained true \
	--runtime win-x64  