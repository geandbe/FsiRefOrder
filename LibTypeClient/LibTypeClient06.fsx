#I __SOURCE_DIRECTORY__
#I ".."
#r "LibBaseType/bin/debug/LibBaseType.dll"
#r "LibDependType/bin/debug/LibDependType.dll"

assert (LibType.LibDependType.DependType(LibType.LibBaseType.BaseType()).DependDependType() = "baseType:dependType")
assert (LibType.LibDependType.DependType(LibType.LibBaseType.BaseType()).DependOwnType() = "dependType")
assert (LibType.LibBaseType.BaseType().BaseType() = "baseType")
