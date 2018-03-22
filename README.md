# FsiRefOrder
### Demo of inconsistent behavior of F# Fsi with regard to the order of #r directives

see [fsi reference order matter #3600](https://github.com/Microsoft/visualfsharp/issues/3600) for some context

I've spotted the issue of occasional significance of order in which `#r directives` are supplied to `fsi` when referenced assemblies are inter-dependent.

Digging deeper shows that `fsi` is agnostic to the order of `#r directives` for libraries containing only static functions in `modules`. This is demonstrated by the group of two libraries `LibBaseModule` and `libDependModule` where 
the latter depends on the former. The scripts `LibModuleClient01.fsx` - `LibModuleClient12.fsx` demonstrate that `fsi` behavior is consistent regardles of the order in which `#r directives` introduce this pair
of libraries to fsiand order in which parts of these libraries are exercised. Besides, this behavior nullifies the assumption that `#r directives` are processed lazily.

The situation changes if we switch to libraries of dependent types `LibBaseType` and `LibDependType`is . Now the behavior of `fsi` depends upon the order of `#r directives` in the following way:

* if the order of `#r directives` for libraries is `LibBaseType`, then `LibDependType` fsi behavior continues to be agnostic to the use order of methods from libraries (`LibTypeClient01.fsx` - `LibTypeClient06.fsx`)

* as soon as the order of `#r directives` is reversed to `LibDependType`, then `LibBaseType` fsi fails on _ANY_ method invocation, even for independent ones (`LibTypeClient07.fsx` - `LibTypeClient12.fsx`)

This inconsistency perhaps is the indication os some subtle bug in the `fsi` manner of resolving references.
