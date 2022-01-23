Imports System
Module Program
' Test 
    Sub Main(args As String())
            if args.length > 0  then 
                for i = 0 to args.length-1
                    Console.WriteLine("args were passed: arg(" & i & "): " & args(i))
                next
            else   
                Console.WriteLine("no args were passed")
            end if
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Hello, World!"))
    End Sub
End Module
