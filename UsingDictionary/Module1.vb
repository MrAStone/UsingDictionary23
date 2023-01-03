Module Module1

    Sub Main()
        Dim dict As New Dictionary(Of Integer, String)
        'Return the length Of the dictionary
        Console.WriteLine(dict.Count)
        'Add a New key: value pair to the dictionary
        dict.Add(1, "This is key 1")
        dict.Add(2, "This is key 2")
        'Delete a key: value pair from the dictionary
        dict.Remove(2)
        'Amend the value in a key: value pair
        dict(1) = "This is key 1 changed"
        dict(1) = dict(1) & " with some more"
        'Return the value associated With key k
        Console.WriteLine(dict(1))
        'Return True Or False depending On whether the key Is In the dictionary
        If dict.ContainsKey(2) Then
            Console.WriteLine(dict(1))
        Else
            Console.WriteLine("Not in dictionary")
        End If
        dict.Add(1, "a new value") 'add
    End Sub

End Module
