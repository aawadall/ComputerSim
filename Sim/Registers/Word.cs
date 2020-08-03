using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSim.Registers
{
    public class Word
    {
        private readonly int _wordSize;
        private bool[] _data;
        private const int _sizeOfByte = 8;
        public Word(int size)
        {
            _wordSize = size;
            _data = new bool[_wordSize];
        }

        public void Set(bool[] input)
        {
            if (input.Length > _wordSize) throw new Exception("Overflow");
            for (int i = 0; i < input.Length; i++)
            {
                _data[_wordSize - input.Length + i] = input[i];
            }
        }

        public void Set(byte[] input)
        {
            if (input.Length > _wordSize) throw new Exception("Overflow");
            for (int i = 0; i < input.Length; i++)
            {
                _data[_wordSize - input.Length + i] = input[i] == 1;
            }
        }
        public bool[] Read()
        {
            return _data;
        }

        public byte[] ReadAsBytes()
        {
            
            int byteSize =(int) Math.Ceiling((decimal) _wordSize / _sizeOfByte);
            
            var result = new byte[byteSize];
            int byteNumber = -1;
            int index = 0;
            while (index < _wordSize)
            {
                if (index % _sizeOfByte == 0) byteNumber++;
                result[byteNumber] = (byte)(result[byteNumber] << 1);
                result[byteNumber] += (byte)(_data[index++] ? 1 : 0); 
            }

            return result;
        }
    }
}
