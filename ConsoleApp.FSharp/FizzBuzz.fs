namespace ConsoleApp.FSharp

open type System.Console

type FizzBuzz =
    static member Run fromNum toNum =
        for i = fromNum to toNum do
            let mutable result = ""
            if i % 3 = 0 then result <- result + "Fizz"
            if i % 5 = 0 then result <- result + "Buzz"
            let message = if result = "" then i.ToString() else result
            WriteLine message