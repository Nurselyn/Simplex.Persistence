packageDir="./artifacts/bin/"

find "$packageDir" -type f -name "*.symbols.nupkg" | while read package; do 
NuGet.exe push "$package" -Source https://www.myget.org/F/greenfence/api/v2/package
done
