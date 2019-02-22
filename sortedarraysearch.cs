//sorted array
		public static int binarySearch(int[] arr, int low, int high, int key)
		{
			if(high < low)
				return -1;
			
			int mid = (low + high) /2;
			
			if(arr[mid] == key)
			{
				return mid;
			}
			
			if(arr[mid] > key)
			{
				return binarySearch(arr, mid + 1, high, key);
			}
			else
			{
				return binarySearch(arr, low, mid -1, key);
			}
			
		}
