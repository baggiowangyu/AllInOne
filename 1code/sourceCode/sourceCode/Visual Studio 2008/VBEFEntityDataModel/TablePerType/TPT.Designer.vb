﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("81333f97-1a07-498e-8383-319167a937bb")> 
Namespace VBEFEntityDataModel.TablePerType
    'Original file name:
    'Generation date: 2009/10/27 15:42:29
    '''<summary>
    '''There are no comments for EFTPTEntities in the schema.
    '''</summary>
    Partial Public Class EFTPTEntities
        Inherits Global.System.Data.Objects.ObjectContext
        '''<summary>
        '''Initializes a new EFTPTEntities object using the connection string found in the 'EFTPTEntities' section of the application configuration file.
        '''</summary>
        Public Sub New()
            MyBase.New("name=EFTPTEntities", "EFTPTEntities")
            Me.OnContextCreated()
        End Sub
        '''<summary>
        '''Initialize a new EFTPTEntities object.
        '''</summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "EFTPTEntities")
            Me.OnContextCreated()
        End Sub
        '''<summary>
        '''Initialize a new EFTPTEntities object.
        '''</summary>
        Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
            MyBase.New(connection, "EFTPTEntities")
            Me.OnContextCreated()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        '''<summary>
        '''There are no comments for People in the schema.
        '''</summary>
        Public ReadOnly Property People() As Global.System.Data.Objects.ObjectQuery(Of Person)
            Get
                If (Me._People Is Nothing) Then
                    Me._People = MyBase.CreateQuery(Of Person)("[People]")
                End If
                Return Me._People
            End Get
        End Property
        Private _People As Global.System.Data.Objects.ObjectQuery(Of Person)
        '''<summary>
        '''There are no comments for People in the schema.
        '''</summary>
        Public Sub AddToPeople(ByVal person As Person)
            MyBase.AddObject("People", person)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EFTPTModel.Admin in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PersonID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="EFTPTModel", Name:="Admin"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class Admin
        Inherits Person
        '''<summary>
        '''Create a new Admin object.
        '''</summary>
        '''<param name="personID">Initial value of PersonID.</param>
        Public Shared Function CreateAdmin(ByVal personID As Integer) As Admin
            Dim admin As Admin = New Admin
            admin.PersonID = personID
            Return admin
        End Function
        '''<summary>
        '''There are no comments for Property AdminDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property AdminDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._AdminDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.OnAdminDateChanging(Value)
                Me.ReportPropertyChanging("AdminDate")
                Me._AdminDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value)
                Me.ReportPropertyChanged("AdminDate")
                Me.OnAdminDateChanged()
            End Set
        End Property
        Private _AdminDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnAdminDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnAdminDateChanged()
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EFTPTModel.BusinessStudent in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PersonID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="EFTPTModel", Name:="BusinessStudent"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class BusinessStudent
        Inherits Student
        '''<summary>
        '''Create a new BusinessStudent object.
        '''</summary>
        '''<param name="personID">Initial value of PersonID.</param>
        Public Shared Function CreateBusinessStudent(ByVal personID As Integer) As BusinessStudent
            Dim businessStudent As BusinessStudent = New BusinessStudent
            businessStudent.PersonID = personID
            Return businessStudent
        End Function
        '''<summary>
        '''There are no comments for Property BusinessCredits in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property BusinessCredits() As String
            Get
                Return Me._BusinessCredits
            End Get
            Set(ByVal value As String)
                Me.OnBusinessCreditsChanging(Value)
                Me.ReportPropertyChanging("BusinessCredits")
                Me._BusinessCredits = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value, True)
                Me.ReportPropertyChanged("BusinessCredits")
                Me.OnBusinessCreditsChanged()
            End Set
        End Property
        Private _BusinessCredits As String
        Partial Private Sub OnBusinessCreditsChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnBusinessCreditsChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Discipline in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Discipline() As String
            Get
                Return Me._Discipline
            End Get
            Set(ByVal value As String)
                Me.OnDisciplineChanging(Value)
                Me.ReportPropertyChanging("Discipline")
                Me._Discipline = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value, True)
                Me.ReportPropertyChanged("Discipline")
                Me.OnDisciplineChanged()
            End Set
        End Property
        Private _Discipline As String
        Partial Private Sub OnDisciplineChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnDisciplineChanged()
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EFTPTModel.Instructor in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PersonID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="EFTPTModel", Name:="Instructor"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class Instructor
        Inherits Person
        '''<summary>
        '''Create a new Instructor object.
        '''</summary>
        '''<param name="personID">Initial value of PersonID.</param>
        Public Shared Function CreateInstructor(ByVal personID As Integer) As Instructor
            Dim instructor As Instructor = New Instructor
            instructor.PersonID = personID
            Return instructor
        End Function
        '''<summary>
        '''There are no comments for Property HireDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property HireDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._HireDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.OnHireDateChanging(Value)
                Me.ReportPropertyChanging("HireDate")
                Me._HireDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value)
                Me.ReportPropertyChanged("HireDate")
                Me.OnHireDateChanged()
            End Set
        End Property
        Private _HireDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnHireDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnHireDateChanged()
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EFTPTModel.Person in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PersonID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="EFTPTModel", Name:="Person"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable(), _
     Global.System.Runtime.Serialization.KnownTypeAttribute(GetType(Admin)), _
     Global.System.Runtime.Serialization.KnownTypeAttribute(GetType(Student)), _
     Global.System.Runtime.Serialization.KnownTypeAttribute(GetType(Instructor))> _
    Partial Public Class Person
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new Person object.
        '''</summary>
        '''<param name="personID">Initial value of PersonID.</param>
        Public Shared Function CreatePerson(ByVal personID As Integer) As Person
            Dim person As Person = New Person
            person.PersonID = personID
            Return person
        End Function
        '''<summary>
        '''There are no comments for Property PersonID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property PersonID() As Integer
            Get
                Return Me._PersonID
            End Get
            Set(ByVal value As Integer)
                Me.OnPersonIDChanging(Value)
                Me.ReportPropertyChanging("PersonID")
                Me._PersonID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value)
                Me.ReportPropertyChanged("PersonID")
                Me.OnPersonIDChanged()
            End Set
        End Property
        Private _PersonID As Integer
        Partial Private Sub OnPersonIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnPersonIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property FirstName in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property FirstName() As String
            Get
                Return Me._FirstName
            End Get
            Set(ByVal value As String)
                Me.OnFirstNameChanging(Value)
                Me.ReportPropertyChanging("FirstName")
                Me._FirstName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value, True)
                Me.ReportPropertyChanged("FirstName")
                Me.OnFirstNameChanged()
            End Set
        End Property
        Private _FirstName As String
        Partial Private Sub OnFirstNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFirstNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property LastName in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property LastName() As String
            Get
                Return Me._LastName
            End Get
            Set(ByVal value As String)
                Me.OnLastNameChanging(Value)
                Me.ReportPropertyChanging("LastName")
                Me._LastName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value, True)
                Me.ReportPropertyChanged("LastName")
                Me.OnLastNameChanged()
            End Set
        End Property
        Private _LastName As String
        Partial Private Sub OnLastNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnLastNameChanged()
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EFTPTModel.Student in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PersonID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="EFTPTModel", Name:="Student"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable(), _
     Global.System.Runtime.Serialization.KnownTypeAttribute(GetType(BusinessStudent))> _
    Partial Public Class Student
        Inherits Person
        '''<summary>
        '''Create a new Student object.
        '''</summary>
        '''<param name="personID">Initial value of PersonID.</param>
        Public Shared Function CreateStudent(ByVal personID As Integer) As Student
            Dim student As Student = New Student
            student.PersonID = personID
            Return student
        End Function
        '''<summary>
        '''There are no comments for Property Credits in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Credits() As String
            Get
                Return Me._Credits
            End Get
            Set(ByVal value As String)
                Me.OnCreditsChanging(Value)
                Me.ReportPropertyChanging("Credits")
                Me._Credits = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value, True)
                Me.ReportPropertyChanged("Credits")
                Me.OnCreditsChanged()
            End Set
        End Property
        Private _Credits As String
        Partial Private Sub OnCreditsChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCreditsChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Degree in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Degree() As Global.System.Nullable(Of Integer)
            Get
                Return Me._Degree
            End Get
            Set(ByVal value As Global.System.Nullable(Of Integer))
                Me.OnDegreeChanging(Value)
                Me.ReportPropertyChanging("Degree")
                Me._Degree = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value)
                Me.ReportPropertyChanged("Degree")
                Me.OnDegreeChanged()
            End Set
        End Property
        Private _Degree As Global.System.Nullable(Of Integer)
        Partial Private Sub OnDegreeChanging(ByVal value As Global.System.Nullable(Of Integer))
        End Sub
        Partial Private Sub OnDegreeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property EnrollmentDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property EnrollmentDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._EnrollmentDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.OnEnrollmentDateChanging(Value)
                Me.ReportPropertyChanging("EnrollmentDate")
                Me._EnrollmentDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(Value)
                Me.ReportPropertyChanged("EnrollmentDate")
                Me.OnEnrollmentDateChanged()
            End Set
        End Property
        Private _EnrollmentDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnEnrollmentDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnEnrollmentDateChanged()
        End Sub
    End Class
End Namespace