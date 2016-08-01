Module PublicModule
    Public Declare Function ReleaseCapture Lib "user32" () As Integer
    Public Declare Function SendMessageA Lib "user32" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer
End Module
