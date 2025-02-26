open System

let rec productOfDigits n =
    if n < 10 then n               
    else (n % 10) * productOfDigits (n / 10)


printf "Введите натуральное число: "
let number = Console.ReadLine() |> int
let result = productOfDigits number
    
printfn "Произведение цифр: %d" result

