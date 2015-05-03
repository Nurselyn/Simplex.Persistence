packageDir="./artifacts/bin/"

find "$packageDir" -type f -name "*.nupkg" | while read package; do 
rm -f "$package"
done
