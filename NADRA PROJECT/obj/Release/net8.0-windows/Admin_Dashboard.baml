   M S B A M L   `   `   `  ����   NADRA PROJECT#    NADRA_PROJECT.Admin_Dashboard   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Admin Dashboard��$
��1080��$
��1920�� � WindowState$ 	Maximized=� � Icon$ /pakistan-govt-logo.png������  �� ImageSource$J DD:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\dashboard.png�� j� Stretch$
 Fill=� � 	Resources    MenuItemStyle �� 
TargetType �� Property �� Value  SubMenuItemStyle  DataGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader  DataGridRowStyle)  #System.Windows.Controls.DataGridRow  DataGridStyle&   System.Windows.Controls.DataGrid��%�  &	        &	 �     &	 9    &	 B    &	     7  7  �� " m�.���  � ��
 �������  � ��
 ���� ��  � ��$ Center=���  � ��$ Center=���  �@�Cursor$
 Hand����  � ��$ 0,0,0,0q���  � ��$ 35���� " m�.���  � ��
 �������  � �� �#009846��  � ��$
 Left=���  �@�Cursor$
 Hand���� "  .���  � ��$ Arial)���  � ��$
 Bold"���  � ��$ 14(���  � �� �#009846��  � ��
 �������  � ��$ 1,0,1,0q���  � �� �#152039��  � ��$ Center=���  � ��$ Center=���  � ��$ 35���� "  .���  � ��
 ���� ��  � ��
 ������� "  .���  � ��$ Center=���  � ��$	 Top=���  � ��$	 400����  � ��$	 800����  �@ AutoGenerateColumns$ False����  � ��
 ���� ��  � �� �#009846��  � ��$ 1q���  � ��$ 0,1,0,0q���  �@ HeadersVisibility$ Column=���  �@ CanUserAddRows$ False����   �@ HorizontalGridLinesBrush �#009846��  �@ VerticalGridLinesBrush �#009846��  �@ ColumnHeaderStyle8   ��  �@ RowStyle8  .��� $��Stretch=�$��Stretch=�	 � RowDefinitions	 �� $��35 ��� $	��120 ��� $��80 ��� $��* �.+�o� $��0��$
��Left=�$	��Top=�$��35��$
��1920�����	#FF009846$��Arial)�$��16(�$��Medium"�.@�m� $	��NIC��#��[  .@�m� -   $��	NIC_AddMI��$��
Add Record��#��[ m� -   $��
NIC_ViewMI��$��View Record��#��[ m� $	��JVC��#��[  .@�m� -   $��	JVC_AddMI��$��
Add Record��#��[ m� -   $��
JVC_ViewMI��$��View Record��#��[ m� $	��CRC��#��[  .@�m� -   $��	CRC_AddMI��$��
Add Record��#��[ m� -   $��
CRC_ViewMI��$��View Record��#��[ m� $	��FRC��#��[  .@�m� -   $��	FRC_AddMI��$��
Add Record��#��[ m� -   $��
FRC_ViewMI��$��View Record��#��[ m� $	��POC��#��[  .@�m� -	   $��	POC_AddMI��$��
Add Record��#��[ m� -
   $��
POC_ViewMI��$��View Record��#��[ m� $��NICOP��#��[  .@�m� -   $��NICOP_AddMI��$��
Add Record��#��[ m� -   $��NICOP_ViewMI��$��View Record��#��[ m� $��
COMPLAINTS��#��[  .@�m� -   $��COMP_ViewMI��$��View Record��#��[ m� $
��EXIT��#��[  .@�m� -   $��	LOGOUT_MI��$��LOG OUT��#��[ �� $��1��$��4��$	��700��
�������$��Center=�$	��Top=�$��0,88,0,0q��� $��1��$��Welcome To Admin Portal�����#152039���#009846$��Arial Black)�$��40(�$��Bottom=�$��Center=�� -   
 �Name$
 
ButtonGrid��$��2��$��Center=�$��Bottom=�$y�Hidden=�$	��490��.+��� -   $��	SearchBox��$��35��$	��200��
������ 
�������$��Arial)�$��14(�
�������$��Center=� � Cursor$ IBeam��$��3q�$
��Left=��� -   $��SearchButton��$��35��$��40��
�������$��Center=�$
 Hand��$��0q�$
��Left=�$��	200,0,0,0q�.���� $L��FD:\VisualProjects\NADRA PROJECT (VP)\NADRA PROJECT\pictures\search.png��$��30��$��40���� -   $��DeleteButton��$��DELETE��$
��Left=�$��Center=�$��35��$	��120�����#009846
�������$��Arial Black)�$��16(�$
��Bold"�$��	245,0,0,0q�$��Center=�$
 Hand��$��0q��� -   $��UpdateButton��$��UPDATE��$��Right=�$��Center=�$��35��$	��120�����#009846$��Arial Black)�$��16(�$
��Bold"�
�������$��0q�$��Center=�  -   $��
NIC_Record��$��3��#��[ $y�Hidden=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	FirstName+  $ 	Last Name��$	 110  �� *
LastName+  $ Father Name��$	 110  �� *
FatherName+  $ Date Of Birth��$	 110  �� *DOB+  $ Gender��$	 110  �� *Gender+  $ Religion��$	 110  �� *
Religion+  $ Address��$ *  �� *	Address+  -   $��NICOP_Record��$��3��#��[ $y�Hidden=�   $ 
First Name��$	 110  �� *	FirstName+  $ 	Last Name��$	 110  �� *
LastName+  $ Father Name��$	 110  �� *
FatherName+  $ Date Of Birth��$	 110  �� *DOB+  $ Gender��$	 110  �� *Gender+  $ Religion��$	 110  �� *
Religion+  $ Address��$ *  �� *	Address+  -   $��
JVC_Record��$��3��#��[ $y�Hidden=�$	��910��   $ 
First Name��$	 110  �� *	FirstName+  $ 	Last Name��$	 110  �� *
LastName+  $ Father Name��$	 110  �� *
FatherName+  $ 
Father NIC��$	 110  �� *	FatherNic+  $ Date Of Birth��$	 110  �� *DOB+  $ Gender��$	 110  �� *Gender+  $ Religion��$	 110  �� *
Religion+  $ Address��$ *  �� *	Address+  -   $��
CRC_Record��$��3��#��[ $y�Hidden=�$	��910��   $ 
First Name��$	 110  �� *	FirstName+  $ 	Last Name��$	 110  �� *
LastName+  $ Father Name��$	 110  �� *
FatherName+  $ 
Father NIC��$	 110  �� *	FatherNic+  $ Date Of Birth��$	 110  �� *DOB+  $ Gender��$	 110  �� *Gender+  $ Religion��$	 110  �� *
Religion+  $ Address��$ *  �� *	Address+  -   $��
POC_Record��$��3��#��[ $y�Hidden=�$
��1100��   $ 
First Name��$	 110  �� *	FirstName+  $ 	Last Name��$	 110  �� *
LastName+  $ Father Name��$	 110  �� *
FatherName+  $ Date Of Birth��$	 140  �� *DOB+  $ Gender��$	 100  �� *Gender+  $ Religion��$	 110  �� *
Religion+  $ Nationality��$	 110  �� *Nationality+  $ Marital Status��$	 130  �� *MaritalStatus+  $ Passport Number��$ *  �� *PassportNumber+  -   $��
FRC_Record��$��3��#��[ $y�Hidden=�$
��1200��   $ Father Name��$	 100  �� *
FatherName+  $ 
Father NIC��$	 100  �� *	FatherNIC+  $ Mother Name��$	 100  �� *
MotherName+  $ 
Mother NIC��$	 100  �� *	MotherNIC+  $ Applicant Name��$	 100  �� *ApplicantName+  $ Applicant NIC��$	 100  �� *ApplicantNIC+  $ Relationship��$	 100  �� *Relationship+  $ F.R.N��$ 80  �� *FRN+  $ Family Members��$	 130  �� *FamilyMembers+  $ Religion��$	 110  �� *
Religion+  $ Per.Address��$	 110  �� *PermanentAddress+  $ Cur.Address��$ *  �� *CurrentAddress+  -   $��Complaint_Record��$��3��#��[ $y�Hidden=�$
��1200��   $ Country��$	 100  �� *	Country+  $ Province��$	 100  �� *
Province+  $ District��$	 100  �� *
District+  $ Tehsil��$	 100  �� *Tehsil+  $ 	Office ID��$	 100  �� *
OfficeID+  $ 	Full Name��$	 100  �� *
FullName+  $ 
NIC Number��$	 100  �� *	NICNumber+  $ Email��$ 80  �� *Email+  $ Dailing Code��$	 100  �� *DailingCode+  $ Contact��$	 110  �� *ContactNumber+  $ 	Complaint��$ *  �� *	Complaint+