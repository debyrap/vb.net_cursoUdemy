'se creo una carpeta llamada conexion y dentro de esta un módulo
'la siguiente sentencia es una importacion para utilizar las funciones de SQLserver en visual studio 
Imports System.Data.SqlClient
Module Conexion_maestra
    'se hace variable "conexion" publica y va a ir una cadena de conección a sql server () La cadena
    'es una cadena de conexion básica: "Data Sources=(servidor de sql); Intial Catalog = (a que DB de conectas); Integrated... es decir conexion a la autenticación de windows (ver en la BD autenticacion no la de SQL sino Windows)
    Public conexion As New SqlConnection("Data Source=DEBY\SQLEXPRESS; Intial Catalog=BASESHOWROOM;Integrated Security= True")

    'se entra a smmsql se conecta y aca se va a especificar cuándo se va a abrir una conexion y cuando cerrar.
    'cuándo se abre
    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    'cuando se cierra
    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub


End Module
