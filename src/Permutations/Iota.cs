using System;

namespace Vee
{
    internal static partial class Permutations
    {
        internal static Span<ulong> Iota(Span<ulong> input, int roundIndex)
        {
            var constants = new ulong[] {
                0x0000000000000001,
                0x0000000000008082,
                0x800000000000808a,
                0x8000000080008000,
                0x000000000000808b,
                0x0000000080000001,
                0x8000000080008081,
                0x8000000000008009,
                0x000000000000008a,
                0x0000000000000088,
                0x0000000080008009,
                0x000000008000000a,
                0x000000008000808b,
                0x800000000000008b,
                0x8000000000008089,
                0x8000000000008003,
                0x8000000000008002,
                0x8000000000000080,
                0x000000000000800a,
                0x800000008000000a,
                0x8000000080008081,
                0x8000000000008080,
                0x0000000080000001,
                0x8000000080008008
            };

            input[0] = input[0] ^ constants[roundIndex];

            return input;
        }
    }
}