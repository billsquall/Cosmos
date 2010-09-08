using System;
using CPUx86 = Cosmos.Compiler.Assembler.X86;

namespace Cosmos.IL2CPU.X86.IL
{
    [Cosmos.IL2CPU.OpCode( ILOpCode.Code.Pop )]
    public class Pop : ILOp
    {
        public Pop( Cosmos.Compiler.Assembler.Assembler aAsmblr )
            : base( aAsmblr )
        {
        }

        public override void Execute( MethodInfo aMethod, ILOpCode aOpCode )
        {
          // todo: implement exception support.
          if (Assembler.Stack.Count > 0) {
            new CPUx86.Pop {
              DestinationReg = CPUx86.Registers.EAX
            };
            Assembler.Stack.Pop();
          }
        }

    }
}