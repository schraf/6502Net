using Unity.Collections;

namespace M6502
{
	public static class Memory
	{
		// allocates a 65536 byte array of data using the persistent allocator
		public static NativeArray<byte> Allocate()
		{
			return new NativeArray<byte>(0x10000, Allocator.Persistent);
		}

		// clears the entire memory to zero
		public static void Clear(NativeArray<byte> memory)
		{
			for (int i = 0; i < memory.Length; ++i)
			{
				memory[i] = 0;
			}
		}

		// load the data into memory at the given offset
		// returns the number of bytes loaded into memory
		public static int Load(NativeArray<byte> memory, int offset, byte[] data)
		{
			int count = 0;

			if (offset < memory.Length)
			{
				for (int i = offset; i < offset + data.Length && i < memory.Length; ++i)
				{
					memory[i] = data[i - offset];
					count++;
				}
			}

			return count;
		}
	}
}