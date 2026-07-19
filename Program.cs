using System;
using System.Collections.Generic;
namespace _mat;

class MainClass
{
    public static void Main (string[] args)
    {
        List <string> subjectList = new List<string>();
        subjectList.Add("Japanese");
        subjectList.Add("Math");
        subjectList.Add("Science");
        subjectList.Add("Englissh");

        // Random random = new Random();
        // int randomIndex = random.Next(0,subjectList.Count);
        // Console.WriteLine(randomIndex);
        // Console.WriteLine(subjectList[randomIndex]);

        List<string> doneSubjectList = new List<string>();
        // for(int i = 0; i < subjectList.Count; i++)
        // {
        //     bool canOutputFlag = false;
        //     int randomIndex = 0;
        //     while(canOutputFlag == false)
        //     {
        //         Random random = new Random();
        //         randomIndex = random.Next(0,subjectList.Count);
        //         string targetSubject = subjectList[randomIndex];
        //         bool doneflag = false;
        //         for (int x = 0; x < doneSubjectList.Count; x++)
        //         {
        //             if(doneSubjectList[x] == targetSubject)
        //             {
        //                 doneflag = true;
        //             }
        //         }
        //         if(doneflag == false)
        //         {
        //             canOutputFlag = true;
        //             doneSubjectList.Add(targetSubject); 
        //         }
        //     }
        //     Console.WriteLine(subjectList[randomIndex]);
        // }

        // List<int> outputList = new List<int>();
        // for(int i = 0; i < subjectList.Count; i++)
        // {
        //     outputList.Add(i);
        // }

        // for(int i = 0; i < subjectList.Count; i++)
        // {
        //     Random random = new Random();
        //     int randomIndex = random.Next(0, outputList.Count);
        //     int targetIndex = outputList[randomIndex];
        //     string targetSubject = subjectList[targetIndex];
        //     outputList.RemoveAt(randomIndex);
        //     Console.WriteLine(targetSubject);
        // }

        Dictionary<string, int> doneSubjectDictionary = new Dictionary<string, int>();
        for(int i = 0; i < subjectList.Count; i++)
        {
            doneSubjectDictionary[subjectList[i]] = 0;
        }
        for(int i = 0; i < subjectList.Count * 2; i++)
        {
            bool canOutputFlag = false;
            int randomIndex = 0;
            while (canOutputFlag == false)
            {
                Random random = new Random();
                randomIndex = random.Next(0,subjectList.Count);
                string targetSubject = subjectList[randomIndex];
                bool doneflag = false;
                if(doneSubjectDictionary[targetSubject] > 1)
                {
                    doneflag = true;
                }
                if(doneflag == false)
                {
                    canOutputFlag = true;
                    doneSubjectDictionary[targetSubject]++;
                }
            }
            Console.WriteLine(subjectList[randomIndex]);
        }

    }
    
}
