namespace Bleak.PortableExecutable.Structures
{
    internal sealed class ExportedFunction
    {
        internal string Name;

        internal readonly int Offset;

        internal readonly short Ordinal;

        internal ExportedFunction(string name, int offset, short ordinal)
        {
            Name = name;

            Offset = offset;

            Ordinal = ordinal;
        }
    }
}