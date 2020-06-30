Imports System

Module Program
    Sub Main(args As String())
        Dim c1 As Car = New Car()
        Dim c2 As Car = New Car()

        c1.owner = "Frahaan"
        Console.WriteLine(c1.owner)
        Console.WriteLine(c2.owner)

        c1.owner = "Batman"
        Console.WriteLine(c1.owner)
        Console.WriteLine(c2.owner)

        Console.WriteLine(c1.speed)
        Console.WriteLine(c1.health)
        Console.WriteLine(c2.speed)
        Console.WriteLine(c2.health)

        c1.DamageCar(14)

        Console.WriteLine(c1.health)
        Console.WriteLine(c2.health)


    End Sub

    Class Vehicle
        Public speed As Integer
        Public health As Double
        Public Shared owner As String '//Shard by all object / Static cSharp

        Public Sub DamageCar(ByVal amount As Integer)
            health = health - amount
        End Sub
    End Class

    'Scope< access modifier in c#
    'Public
    'Private
    'Protected


    '//Inheritance
    Class Car : Inherits Vehicle

        Public Sub New() '//Contructor in vb NEW 
            'Console.WriteLine("An Instance of class created")
            speed = 120
            health = 100
        End Sub

        Public Sub HelloCar()
            Console.WriteLine("Hello I am a car")
        End Sub

        Protected Overrides Sub Finalize() '//Destructor in vb Finalize 
            '.net core dont run destuctor because changes in garbage collector
            Console.WriteLine("An Instance of class destroyed")

        End Sub
    End Class
End Module
