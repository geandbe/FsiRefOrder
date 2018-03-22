#I __SOURCE_DIRECTORY__
#I ".."
#r "LibDependModule/bin/debug/LibDependModule.dll"
#r "LibBaseModule/bin/debug/LibBaseModule.dll"

assert (LibModule.LibDependModule.dependOwnFun() = "dependVal")
assert (LibModule.LibBaseModule.baseFun() = "baseVal")
assert (LibModule.LibDependModule.dependDependFun() = "baseVal:dependVal")
