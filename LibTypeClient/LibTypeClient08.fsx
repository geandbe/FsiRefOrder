#I __SOURCE_DIRECTORY__
#I ".."
#r "LibDependType/bin/debug/LibDependType.dll"
#r "LibBaseType/bin/debug/LibBaseType.dll"

assert (LibType.LibBaseType.BaseType().BaseType() = "baseType")
assert (LibType.LibDependType.DependType(LibType.LibBaseType.BaseType()).DependDependType() = "baseType:dependType")
assert (LibType.LibDependType.DependType(LibType.LibBaseType.BaseType()).DependOwnType() = "dependType")

