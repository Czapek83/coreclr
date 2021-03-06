using System;
using System.Runtime.InteropServices;

public class UnmanagedTypeTest
{
    public static int Main()
    {
        UnmanagedTypeTest test = new UnmanagedTypeTest();
        return 100 + test.RunTests();
    }

    private int RunTests()
    {
        int nErrorCount = 0;
        nErrorCount += Verify(UnmanagedType.AsAny, 40);
        nErrorCount += Verify(UnmanagedType.Bool, 2);
        nErrorCount += Verify(UnmanagedType.ByValArray, 30);
        nErrorCount += Verify(UnmanagedType.ByValTStr, 23);
        nErrorCount += Verify(UnmanagedType.Currency, 15);
        nErrorCount += Verify(UnmanagedType.Error, 45);
        nErrorCount += Verify(UnmanagedType.FunctionPtr, 38);
        nErrorCount += Verify(UnmanagedType.I1, 3);
        nErrorCount += Verify(UnmanagedType.I2, 5);
        nErrorCount += Verify(UnmanagedType.I4, 7);
        nErrorCount += Verify(UnmanagedType.I8, 9);
        nErrorCount += Verify(UnmanagedType.LPArray, 42);
        nErrorCount += Verify(UnmanagedType.LPStr, 20);
        nErrorCount += Verify(UnmanagedType.LPStruct, 43);
        nErrorCount += Verify(UnmanagedType.LPTStr, 22);
        nErrorCount += Verify(UnmanagedType.LPWStr, 21);
        nErrorCount += Verify(UnmanagedType.R4, 11);
        nErrorCount += Verify(UnmanagedType.R8, 12);
        nErrorCount += Verify(UnmanagedType.Struct, 27);
        nErrorCount += Verify(UnmanagedType.SysInt, 31);
        nErrorCount += Verify(UnmanagedType.SysUInt, 32);
        nErrorCount += Verify(UnmanagedType.U1, 4);
        nErrorCount += Verify(UnmanagedType.U2, 6);
        nErrorCount += Verify(UnmanagedType.U4, 8);
        nErrorCount += Verify(UnmanagedType.U8, 10);
#if WINCORESYS
        nErrorCount += Verify(UnmanagedType.AnsiBStr, 35);
        nErrorCount += Verify(UnmanagedType.BStr, 19);
        nErrorCount += Verify(UnmanagedType.CustomMarshaler, 44);
        nErrorCount += Verify(UnmanagedType.IDispatch, 26);
        nErrorCount += Verify(UnmanagedType.Interface, 28);
        nErrorCount += Verify(UnmanagedType.SafeArray, 29);
        nErrorCount += Verify(UnmanagedType.TBStr, 36);
        nErrorCount += Verify(UnmanagedType.VariantBool, 37);
        nErrorCount += Verify(UnmanagedType.VBByRefStr, 34);
#endif
        if (nErrorCount == 0)
            Console.WriteLine("Pass!");
        else
            Console.WriteLine("Fail! ErrorCount: {0}", nErrorCount);
        return nErrorCount;
    }

    private int Verify(UnmanagedType umt, int expectedValue)
    {
        Console.WriteLine("Verify " + umt);
        try
        {
            if (expectedValue == (int)umt)
                return 0;

            Console.WriteLine("Error! Actual: {0}, Expected: {1}", (int)umt, expectedValue);
        }
        catch (Exception e)
        {
            Console.WriteLine("UnexpectedEception: " + e);
        }
        return 1;
    }
}
