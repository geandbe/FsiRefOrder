namespace LibType

module LibDependType =

    type DependType (baseType:LibBaseType.BaseType) = 
        let dependType = "dependType"
        member __.DependOwnType() = dependType
        member __.DependDependType() = baseType.BaseType() + ":" + dependType