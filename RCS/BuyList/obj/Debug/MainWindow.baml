   M S B A M L   `   `   `  ����B  >BuyList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BuyListBuyList  5   	       BuyList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BuyList     5   	     � Title$  Pirkumi��5   	   $��506.695��6   $��647.04��6*   ��5	      �� 5
   
    �� ImageSource$D >D:\Kristaps\Codes\BadassProject_01\RCS\BuyList\Images\list.jpg��6   .��5      � $��
0,0,-8,-21q�6    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      �� 5      $��0* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ BuyListItemName��5      $
��Left=�6+   $��41��6F   $��7,47,0,0q�6R    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��173��6�   $��1��6�   �� 5   
   -   5         ��Name$ AddListButton��5      
�������$��Pievienot pirkumu��6^   $��1��6z   $
��Left=�6�   $��
197,47,0,0q�6�   $	��Top=�6�   $	��119��6�   $��41��6�   �� 5   
   $��Iepirkumu saraksts:��6   
�������$
��Left=�6F   $��	7,138,0,0q�6a   $	��Top=�6t   $��33��6�   $	��139��6�   $��1��6�   �� 5   
   $��7,176,395,135q�6   $��1��6.   .��5      �� -   5         ��Name$ BuyItemsListControl��5      
�������$	��245��6K    �� SelectionMode$ Multiple=�6W   ��5      �� 5      .R�5      � .+�5      �� $��Ariel)�6(   ��6;   �� 5      5      5      5       �� 5#   
   $��Ievadi pirkumu!��6   
�������$��1��6B   $
��Left=�6R   $��	10,10,0,0q�6m   $	��Top=�6�   $��32��6�   $��98��6�   �� 5$   
   -   5        $ 
SaveButton��5$      
�������$��	Saglabāt��6X   $��1��6k   $
��Left=�6{   $��495,355,0,0q�6�   $	��Top=�6�   $	��118��6�   $��42��6�    J� RenderTransformOrigin$ 0.853,2.159&�6�   �� 5%   
   -   5        $ ResetButton2��5%      
�������$��	Ielādēt��6[   $��1��6m   $
��Left=�6}   $��495,402,0,0q�6�   $	��Top=�6�   $	��118��6�   $��42��6�   $ 0.853,2.159&�6�   �� 5&   
   -   5        $ DeleteButton��5&      
�������$��Dzēst��6\   $��1��6l   $
��Left=�6|   $��133,367,0,0q�6�   $	��Top=�6�   $	��119��6�   $��41��6�   5'      5(      