﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


	<System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")>
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<System.Configuration.ApplicationScopedSettingAttribute()>
		<System.Diagnostics.DebuggerNonUserCodeAttribute()>
		<System.Configuration.SpecialSettingAttribute(System.Configuration.SpecialSetting.ConnectionString)>
		<System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb;Persist Se" & "curity Info=True")>
		Public ReadOnly Property nwindConnectionString() As String
			Get
				Return (DirectCast(Me("nwindConnectionString"), String))
			End Get
		End Property
	End Class
End Namespace