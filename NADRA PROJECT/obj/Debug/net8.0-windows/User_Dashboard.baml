   M S B A M L   `   `   `  ����H  DNADRA PROJECT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NADRA_PROJECTNADRA_PROJECT  5   	   "    NADRA_PROJECT.User_Dashboard   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:NADRA_PROJECT     5   	     � Title$  User Dashboard��5   	   $
��1080��6    $
��1920��6.    � WindowState$ 	Maximized=�6;    � Icon$ /pakistan-govt-logo.png��6S   ��5	      �� 5
   
    �� ImageSource$J DD:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\dashboard.png��6    j� Stretch$
 Fill=�6h   6y    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value  NameBlockStyle��%(  &	        &	 :    �� 5   
   " ��6$   .�5      ��  � ��
 �����6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ Center=�69   �� 5       � ��$ Center=�62   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 0,0,0,0q�60   �� 5       � ��$ 35��6'   5      �� 5   
   " ��6'   .�5      ��  � �� �#0098466+   �� 5       � ��
 ���� 6+   �� 5       � ��$ Arial Black)�6+   �� 5       � ��$ 14(�6)   �� 5       � ��$	 170��6&   �� 5       � ��$ 	20,20,0,0q�6'   �� 5       � ��$ Center=�62   �� 5       � ��$
 Left=�64   �� 5        �@�Cursor$
 Hand��6'   �� 5!       � ��$ 30��6'   �� 5"       � ��$
 Wrap=�6-   5#      5$      .��5&      � .+�5'   
   o� $
��Left=�6   $	��Top=�5(      $��35��5)      $
��1920��6   ���	#FF009846$��Arial)�5*   &   $��14(�5+      $
��Bold"�6   .@�5-      �� -   5        $��about��5-      $��About NADRA��6"   #��[  5.      5/      �� 50      -   5        $��media��50      $��Media��6"   #��[  51      52      �� 53      -   5        $��
complaints��53      $��
Complaints��6'   #��[  54      55      �� 56      -   5        $��careers��56      $��Careers��6$   #��[  57      6:   �� 58      -   5        $��offices��58      $��Offices��6$   #��[  59      6:   �� 5:      -   5        $��	contactUs��5:      $��
Contact us��6&   #��[  5;      5<      �� 5=      -   5        $
��exit��5=      $
��Exit��6!   #��[  5>      6:   5@      � 5B   
   $��Center=�6   $��Center=�6*   $��0,50,0,0q�6G   	 � RowDefinitions	 5C      �� 5D      $	��310 �6    6/   �� 5E      $	��310 �6    6/   
 � ColumnDefinitions
 5G      �� 5H      $	��290 �6#   61   �� 5I      $	��290 �6#   61   �� 5J      $	��290 �6#   61   .+�5M      �� -   5        $	��NIC��5M      
�������$��0��67   $��0��6G   $��5,0,5,5q�6T    � Cursor$
 Hand��6e   .+�5N      �� $D��>D:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\NIC.jpg��6   $	��186��6a   �� 5O      $��National Identity Card��6   #��[ 5P      6G   �� 5Q      
���   �
������ $��Arial)�6H   $I��CNational Identity Card (NIC) is issued to the citizens of Pakistan.��5R      $
��Left=�5S      $��20,5,0,0q�67   $	��236��6I   $��32��6V   $
��Wrap=�6b   5T      �� 5V      -	   5        $	��JVC��5V      
�������$��1��67   $��0��6G   $��5,0,5,5q�6T   $
 Hand��6e   .+�5W      �� $Q��KD:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\JuvenileCard-img.jpg��6   $	��186��6n   �� 5X      $��Juvenile Card��6   #��[ 5Y      6I   �� 5Z      
���   �
������ $��Arial)�6H   $U��OJuvenile card is an identity card issued to children under the age of 18 years.��6[   $
��Left=�6�   $��20,5,0,0q�6�   $	��236��6�   $��30��6�   $
��Wrap=�6�    � ForceCursor$
 True��6  5[      �� 5]      -
   5        $	��POC��5]      
�������$��2��67   $��0��6G   $��5,0,5,5q�6T   $
 Hand��6e   .+�5^      �� $H��BD:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\POC-img.jpg��6   $	��186��6e   �� 5_      $��Pakistan Origin Card��6   #��[ 5`      6H   �� 5a      
���   �
������ $��Arial)�6H   $R��LPakistan Origin Card (POC) program endeavors to provide eligible foreigners.��6[   $
��Left=�6�   $��20,5,0,0q�6�   $	��236��6�   $��37��6�   $
��Wrap=�6�   5b      �� 5d      -   5        $	��FRC��5d      
�������$��0��67   $��1��6G   $��5,5,5,0q�6T   $
 Hand��6e   .+�5e      �� $H��BD:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\FRC-img.jpg��6   $	��186��6e   �� 5f      $%��Family Registration Certificate��6   #��[ 5g      $	��210��5h      $��34��6*   68   �� 5i      
���   �
������ $��12(�6H   $��Arial)�6V   $`��ZFamily Registration Certificate (FRC) is a means of being identified with NADRA’s record��6i   $
��Left=�6�   $��	20,10,0,0q�6�   $	��236��6�   $��43��6  $
��Wrap=�6  5j      �� 5l      -   5        $	��CRC��5l      
�������$��1��67   $��1��6G   $��5,5,5,0q�6T   $
 Hand��6e   .+�5m      �� $H��BD:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\CRC-img.jpg��6   $	��186��6e   �� 5n      $$��Child Registration Certificate��6   #��[ 5o      6H   �� 5p      
���   �
������ $��12(�6H   $��Arial)�6V   $`��ZChild Registration Certificate is a means of registering a new born with your NADRA record��6i   $
��Left=�6�   $��	20,10,0,0q�6�   $	��236��6�   $��46��6  $
��Wrap=�6  5q      �� 5s      -   5        $��NICOP��5s      
�������$��2��69   $��1��6I   $��5,5,5,0q�6V   $
 Hand��6g   .+�5t      �� $J��DD:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\NICOP-img.jpg��6   $	��186��6g   �� 5u      $4��.National Identity Card for Overseas Pakistanis��6   #��[ 5v      $	��198��5w      $��42��6*   69   �� 5x      
���   �
������ $��Arial)�6H   $��12(�6[   $[��UNational Identity Card for Overseas Pakistanis is issued to the overseas of Pakistan.��6i   $	��236��6�   $��40��6�   $
��Wrap=�6�   5y      5{      5}      5~      