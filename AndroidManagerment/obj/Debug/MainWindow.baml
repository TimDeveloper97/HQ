   M S B A M L   `   `   `  ����I  EProjectManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AndroidManagermentAndroidManagerment  5   	   clr-namespace:DAODAO  5	   	   clr-namespace:ModelsModels  5
   	   7 clr-namespace:AndroidManagermentAndroidManagerment  5   	   #    AndroidManagerment.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AndroidManagerment     5   	   "selfclr-namespace:DAO     5	   	   &modelclr-namespace:Models     5
   	   1here clr-namespace:AndroidManagerment     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ Icons/tools.png��6.   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   � $��0��6   ���#a06946 � ColumnDefinitions 5      �� 5       $
��0.3* �6#   �� 5!      $
��0.7* �6#   .+�5$      � $��0��6   $��Center=�5%      $��Center=�60   .+�5&      �� -   5        $��lTitle��5&      $��23(�5'      $��SemiBold"�6&   $��Italic$�6<   
�������$��30��5(   +   $��Bottom=�5)      5+      � 5,      $��1��6   $��Center=�5-      $��Center=�60   .+�5.      �� -   5        $��lList��5.      $��23(�5/      $��SemiBold"�6&   $��Italic$�6<   
�������50      51      52      � 56   
   $��1��6    57      �� 58      $
��0.3* �6#   �� 59      $
��0.7* �6#   .+�5=      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�62   .��5>      R� -   5        $��tvMenu��5>      $	��220��6)   $��5q�68    � 	Resources 5?       �� DataType   Models.Menu �� ItemsSource	 �� Path
 �� Orientation �� Padding   Models.Member��%[  (��       5@   3   *, +)(�� n    5L   '   *, +)�� 5@      "  63    6R   �� $	 Members�.R�5A      �� $
 
Horizontal=�6)   .+�5B   "   �� $��20��6(   $��UniformToFill=�63   $��0,0,5,0q�6j   ��6K   �� $	 Source�6j   �� 5C   "   $ 0,3,0,0q�6G   $��Italic$�5D   ,   $��SemiBold"�6?   $��16(�6U   ��5C   ,   �� $
	 Name�5D   U   �� 5E   "   $
 
Horizontal=�6-   $��	0,1.5,0,0q�6F   .+�5F   &   �� $�� [��60   ���#1a75ff$ 0,3,0,0q�6P   �� 5G   &   ���#1a75ff$ 0,3,0,0q�6j   ��60   �� $	 Members.Count�6j   �� 5H   &   $��]��60   ���#1a75ff$ 0,3,0,0q�6O   5I   #   5J      5K      �� 5L      "  6'   .R�5M      �� $
 
Horizontal=�6)   .+�5N   "   �� $��20��6(   $��UniformToFill=�63   $��/Icons/folder.png��6K   $��0,0,5,0q�6f   �� 5O   "   $ 0,3,0,0q�6C   ��6,   �� *Name+6C   �� 5P   "   $�� (��6,   
��� � �$ 0,3,0,0q�6J   �� 5Q   "   
��� � �$ 0,3,0,0q�6W   ��6,   �� *Count+6W   �� 5R   "   $��
 projects)��6,   
��� � �$ 0,3,0,0q�6R   5S      5T      5U      5V      5W        5[      $��1��6"   $��0,5,5,5q�62   .��5\      �� -   5        $��	lvContent��5\       5]         DAO.ProjectInfoDAO  MaterialDesignToolButton'  !MaterialDesignThemes.Wpf.PackIcon   Kind��%~  (��       5^   3   *, +)�� 6   "  63   .R�5_      � $	��650��6#   .+�5`   "   �� ���#a06946$
��Left=�6=   $��3��5a   (   � 5b   "   $��8,0,0,0q�6'   .+�5c   &   �� $��2q�61   .+�5d   *   �� $��Italic$�6P   $��16(�6c   $��SemiBold"�5e   4   ��5d   4   �� $	 Title�5e   4   �� 5f   *   
���iii�$��11(�6d   ��64   �� $
	 Path�6d   5g   '   � 5h   &   $��Right=�60   $��Center=�6L   .+�5i   *   �� $��	btnDelete��61   -   5        $��DELETE��5i   B   ���#ff5c33$��60��5j   1   $��30��6<   #���  6H   �� 5k   *   $��btnEdit��61   -   5        $
��EDIT��5k   @   ���#53c68c$��60��5l   1   $��30��6<   #���  6H   �� 5m   *   $��btnCopy��61   -   5        ���#a64dff$��30��5n   1   $��30��6<   #���  6H   .��5o   .     $ ContentCopy=�6F   5p   +   5q   '   5r   #   5s      5t      5u      5v      5w      5y      � 5|   
   $��1��6   $��Center=�6   $��Center=�69   .+�5~      )  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��6(   $��Bottom=�5      $��16q�6F      IsOpen 6,   �� *IsShow+5�      5�      5�      5�      