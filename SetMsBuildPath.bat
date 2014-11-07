@ECHO OFF

pushd %windir%
cd "Microsoft.NET\Framework\v4.0.30319"
SET PATH=%PATH%;%CD%
popd
