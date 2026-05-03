public class DynamicArray
    {
        private int[] memory;
        private int capacity;
        private int size;

        public DynamicArray(int capacity)
        {
            memory = new int[capacity];
            this.capacity = capacity;
            this.size = 0;
        }

        public int Get(int i)
        {
            return memory[i];
        }

        public void Set(int i, int n)
        {
            memory[i] = n;
        }

        public void PushBack(int n)
        {
            if (size == capacity)
            {
                Resize();
            }
            memory[size] = n;
            size++;
        }

        public int PopBack()
        {
            if(size > 0)
            {
                size--;
            }
            return memory[size];
        }

        private void Resize()
        {
            capacity = capacity * 2;
            int[] newMem = new int[capacity];
            for (int i = 0; i < size; i++)
            {
                newMem[i] = memory[i];
            }
            memory = newMem;
        }

        public int GetSize()
        {
            return size;
        }

        public int GetCapacity()
        {
            return this.capacity;
        }
    }