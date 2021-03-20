Imports System

Module Program
' Test 
    Sub Main(args As String())
            dim args_passed as Boolean
            if args.length >0 then
                args_passed = true
            else 
                args_passed = false
            end if   
            if args_passed then 
                for i = 0 to args.length-1
                    Console.WriteLine("args were passed: " & " arg(" & i & "): " & args(i))
                next
            else   
                Console.WriteLine("no args were passed")
            end if

            Console.WriteLine("Hello World!")
            for i = 1 to 10
            Console.Write(i & " ")
            next i
    End Sub
End Module
