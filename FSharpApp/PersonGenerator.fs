﻿namespace FSharpApp

type Person =
    {
        Id: int;
        PersonalNumber: string;
        Amount: int;
        RegisteredDate: int;
        Signature: string;
        Salary: int;
        Earned: int
     }

type PersonGenerator() =
    let randomNumberGenerator = new System.Random()
    let personalNumber = 
        List.init 900 (fun _ -> randomNumberGenerator.Next(0,9)) 
                                    |> Seq.map string 
                                    |> String.concat "Number"
    
    let createPerson id =
        let person = {
            Id=id;
            PersonalNumber= personalNumber;
            Amount=randomNumberGenerator.Next(0,10);
            RegisteredDate=2000+randomNumberGenerator.Next(0,9);
            Signature="Signature";
            Salary = randomNumberGenerator.Next(100,1000);
            Earned = 0
           }
        person

    member this.GetPersons (count:int) = 
        List.init count (fun index -> createPerson index)