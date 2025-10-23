// (c) gfoidl, all rights reserved

namespace gfoidl.Trx2Junit.Core.Abstractions
{

    public interface ITestConverter<TIn, TOut>
        where TIn : Models.Test
        where TOut : Models.Test
    {
        TIn SourceTest { get; }
        TOut Result { get; }
        //-------------------------------------------------------------------------
        void Convert();
    }
}
