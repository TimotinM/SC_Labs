   M S B A M L   `   `   `  ����C  ?WpfAudit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfAuditWpfAudit  5   	       WpfAudit.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfAudit     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1400��6)    � 	Resources 5
       �� 
TargetType �� Property �� Value   	BoolToVis  listTemplate d� 	IsChecked �� Path 9� 
IsExpanded �� 	Converter��%�  '��       '�� H     &	  �     &	 �     7   �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       �@��TextWrapping$ WrapWithOverflow=�6-   5      �� 5   
   6'   �� 5   
   .R�5      �� $	��400��6   $��0,20,5,0q�6%   .+�5      �� $��20��6@   $��Select Policy��6L    6   �� $ 	PolicyBox�6L   9� 5      $��Reason��6   $
 True��6+   y�6=   �� $ VisibleReason�8   .��5      �� ��6   �� $ Reason�5       9� 5"      $��Policy Type��6   .��5#      �� ��6   �� $ 
PolicyType�5$      9� 5&      $��Policy Description��6   .��5'      �� ��6   �� $ PolicyDescription�5(      9� 5*      $��Policy Info��6   .��5+      �� ��6   �� $ 
PolicyInfo�5,      9� 5.      $��Policy Solution��6   .��5/      �� ��6   �� $ PolicySolution�50      9� 52      $��Policy See Also��6   .��53      �� ��6   �� $ PolicySeeAlso�54      9� 56      $��Policy Value Type��6   .��57      �� ��6   �� $ PolicyValueType�58      9� 5:      $��Policy Value Data��6   .��5;      �� ��6   �� $ PolicyValueData�5<      9� 5>      $��Policy Reg Key��6   .��5?      �� ��6   �� $ PolicyRegKey�5@      9� 5B      $��Policy Reg Item��6   .��5C      �� ��6   �� $ PolicyRegItem�5D      9� 5F      $��Policy Reg Option��6   .��5G      �� ��6   �� $ PolicyRegOption�5H      9� 5J      $��Policy Reference��6   .��5K      �� ��6   �� $ PolicyReference�5L      5M      5N      5O      .��5Q      � 	 J� RenderTransformOrigin$	 
0.48,0.527&�6   
 � ColumnDefinitions
 5R   
   �� 5S      $��2.14* �6   �� 5T      $��5* �6   .+�5W   
   �� $��1��6   ��6   �� *Audits+ �� SelectedItem 5X      �� *SelectedAudit+��5Y      �� 5Z      .R�5[      �� $��5q�6!   .+�5\      �� $��18(�6$   ��62   �� $ DisplayName�5^      5_      5a      �� 5e   
   $��1��6   $��Bottom=�6"   .+�5f      �� ��6   �� *
AddCommand+.��64   Upload file6A   �� 5g      ��6   �� *RemoveCommand+��5h      �� *SelectedAudit+.��6@   Remove File6M   5j      �� 5m   
   #��[ 6   $��0,70,0,0q�5n      $��Disabled=�5o      $��1��5p      ��6"   �� *SelectedAudit.CustomItems+ 5q      �� *SelectedAudit+��5t      �� 5u      .R�5w      � 5y      5{      �� 5   
   $��1��6*   $
��Left=�6:   $��
212,26,0,0q�6U   $	��Top=�6i   $	��170��6�   $��20��6�   ��6   �� *Search+6�   �� 5�   
   $��Search��64   $��1��6E   $
��Left=�6U   $��
400,26,0,0q�6p   $	��Top=�6�   $��68��6�   $��21��6�   ��6   �� *SearchCommand+6�   �� 5�   
   $��1��6,   $
��Left=�6<   $��
542,26,0,0q�6W   $	��Top=�6k   $	��168��6�   ��6   �� *
SaveName+6�   �� 5�   
   $��Save As��62   $��1��6D   $
��Left=�6T   $��
734,27,0,0q�6o   $	��Top=�6�   $��59��6�   $��20��6�   ��6   �� *SaveCommand+6�   �� 5�   
    d� IsThreeState$ False��6   $��Select All Policies��6(   $��1��6F   $
��Left=�6V   $��	26,24,0,0q�6q   $	��Top=�6�   $��29��6�   $	��129��6�    5�          WpfAudit.CheckBoxConverter 
 cbConv��%   &	         5�      6*   5�       5�      `� 5�       `� 	Converter# [ 6   .1�5�      �� $ CheckPolicies�6   5�      ��5�      �� 5�      " ��6    �� Triggers 5�      P� 5�       P� Property �@d�	IsChecked P� Value$
 trueY�67   . �5�      ��  � ��
 � � �6;   5�      P� 5�       �@d�	IsChecked$ falseY�67   . �5�      ��  � ��
 �  ��6;   5�      5�      5�      �� 5�   
   $
��SCAN��62   $��1��6A   $
��Left=�6Q   $��
864,26,0,0q�6l   $	��Top=�6�   $��68��6�   $��22��6�   ��6   �� *ScanCommand+6�   5�      5�      