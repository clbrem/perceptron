namespace MyAssert

type Assert<'T>() =
    inherit Xunit.Assert()
    static member FailWith (fmt) (item: 'T) =
        Assert.Fail(sprintf fmt item)
    static member EqualTo (expected: 'T) (actual: 'T) =
        Assert.Equal(expected, actual)
    

