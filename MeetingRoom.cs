using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        Interval[] arr = new Interval[4];
        
        arr[0] = new Interval(0, 30);
        arr[1] = new Interval(5,10);
        arr[2] = new Interval(15, 20);
        arr[3] = new Interval(25, 30);
        
        MeetingRoom m = new MeetingRoom();
        
        bool canattend = m.CanAttendAllMeetings(arr);
        
        Console.WriteLine("Can attend all meetings: " + canattend);
        
        
        Interval[] arr1 = new Interval[2];
        
        arr1[0] = new Interval(7, 10);
        arr1[1] = new Interval(2,4);
        
        MeetingRoom m1 = new MeetingRoom();
        
        bool canattend1 = m1.CanAttendAllMeetings(arr1);
        
        Console.WriteLine("Can attend all meetings: " + canattend1);
        
        
    }
}

public class Interval
{
    public int Start { get; set; }
    
    public int End { get; set; }
    
    public Interval(int start, int end)
    {
        Start = start;
        End = end;
    }
}

public class MeetingRoom
{
    public bool CanAttendAllMeetings(Interval[] arr)
    {
        int length = arr.Length;
        
        int[] startarr = new int[length];
        
        int[] endarr = new int[length];
        
        for(int i=0; i<length; i++)
        {
            startarr[i] = arr[i].Start;
            endarr[i] = arr[i].End;
        }
        
        Array.Sort(startarr);
        Array.Sort(endarr);
        
        //check to see if the start time of next event overlaps
        //with the end time of current 
        //[0,30], [5, 10]
        for(int j=0; j<length-1; j++)
        {
            if(startarr[j+1] < endarr[j])
            {
                return false;
            }
        }
        return true;
    }
    
    public void MinimumNumberOfConfRooms(List<Interval> meetings)
    {
        IntervalComparer ic = new IntervalComparer();
        
        meetings.Sort(ic);
        
        int maxOverlap=1;
        
        int overlap=0;
        
        for(int i=0; i<meetings.Count-1 && overlap+i<meetings.Count-1 ;++i)
        {
            int j=i+1;
            
            Interval temp=meetings[j];
            Interval present=meetings[i];
            overlap=0;
            
            while(temp.Start<present.End && j<meetings.Count)
            {
                temp=meetings[j];
                overlap++;
                ++j;
                
                Console.WriteLine("in overlap");
            }
            if(overlap+1>maxOverlap)
            {
                maxOverlap=overlap+1;
            }
        }
        Console.WriteLine(maxOverlap);
    }
}
