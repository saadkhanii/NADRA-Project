   M S B A M L   `   `   `  ����H  DNADRA PROJECT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NADRA_PROJECTNADRA_PROJECT  5   	       NADRA_PROJECT.LoginPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:NADRA_PROJECT     5   	     � Title$  Login��5   	   $
��1080��6   $
��1920��6%    � WindowStartupLocation$ CenterScreen=�62    � WindowState$ 	Maximized=�6W    � Icon$ /pakistan-govt-logo.png��6o   ��5	      �� 5
   
    �� ImageSource$K ED:\VisualProjects\NADRA PROJECT\NADRA PROJECT\pictures\main_frame.png��6    j� Stretch$
 Fill=�6i   6z   .��5      � $��Center=�6   $��Center=�6&   .+�5   
      NADRA_PROJECT.CustomPanel  $	��450��6   $	��380��6)   .+�5      � $��Center=�6   $��Center=�60   $	��420��6K   $	��320��6X    � RowDefinitions 5      �� 5      $	��100 �6$   63   �� 5      $��70 �6$   62   �� 5      $��70 �6$   62   �� 5      6&   �� 5      6&   .+�5      �� $��0��6   $��Login��5      $
��Left=�5      $��Center=�61   ���	#FF152039$��Arial Black)�5   -   $��30(�5      $
��Bold"�6$   �� 5      $��1��6   $��
User Name:��5      $
��Left=�5       $	��Top=�61   ���	#FF152039$��Arial)�5"      $��20(�6)   $
��Bold"�5#      $��0,12,0,0q�6(   �� 5$      -   5        $��username��5%      $��1��5$      $
��Left=�5&      $��Bottom=�5'      $��28��5(      $	��212��6!    �� TextWrapping$
 Wrap=�5)       �� SelectionBrush �	#00000000$��Center=�5+      
���   �5,      �� 5-      $��2��6   $��	Password:��5.      $
��Left=�5/      $	��Top=�50      ���	#FF152039$��Arial)�51   ,   $��20(�52      $
��Bold"�6#   $��0,12,0,0q�65   G� 53      -   5        $��password��54      $��2��53      $��28��55      $	��212��6"   $��Bottom=�56      $
��Left=�57      	 G� SelectionBrush	 �	#00000000$��Center=�59      
���   �5:      �� 5;      -   5        
 ��Name$
 loginButton��5<      $��3��5;      $��Login��5<   *   $
��Left=�5=      $��32��5>      $	��212��6!   $��Center=�5?      $��Arial Black)�5@      
����������	#FF152039
������� � Cursor$
 Hand��5B   )   5C      �� 5D      $��4��6   $��Don't have an account?��5E      $
��Left=�5F      $	��Top=�60   
�������$��Arial)�5G   (   �� 5H      -   5         ��Name$ signin��5I      $��4��5H      $��SignUp!��5I   %   $��Center=�5J      $	��Top=�62   ���	#FF152039$��Arial)�5K   ,   $��56��5L      $
��Bold"�6    $
 Hand��62   $��60,0,0,0q�5M   F   5N      5O      5P      5Q      