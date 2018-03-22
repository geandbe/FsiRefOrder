#I __SOURCE_DIRECTORY__
#I ".."
#r "LibBaseModule/bin/debug/LibBaseModule.dll"
#r "LibDependModule/bin/debug/LibDependModule.dll"

assert (LibModule.LibDependModule.dependOwnFun() = "dependVal")
assert (LibModule.LibBaseModule.baseFun() = "baseVal")
assert (LibModule.LibDependModule.dependDependFun() = "baseVal:dependVal")
