namespace LibModule
module LibDependModule =

    let dependVal = "dependVal"

    let dependOwnFun() = dependVal

    let dependDependFun() = LibBaseModule.baseVal + ":" + dependVal
