   M S B A M L   `   `   `  ����I  EPassword saver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Password_saverPassword_saver  5   	       Password_saver.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Password_saver     5   	   -   5          � Title$  Password saver��5   	   $	��350��6    $	��300��6-   
�����p� � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �� .+�5   
   �� -   5         ��Name$ myServiceLabel��5   $   $y�Hidden=�6   $��Service��6<   $��Center=�6N   $��71,40,127,0q�6k   $��94��6�   �� 5   
   -   5         ��Name$ myServiceText��5      $��30��6*    �� TextWrapping$
 Wrap=�67   $��5q�6K   $��Service��6W   $	��150��6f   $��Center=�6s   $
��71,0q�6�   $��Center=�6�   $��Italic$�6�   ��6�   Z� 6  �� 5   
   -   5        $ myEmailLabel��5   $   $y�Hidden=�6   $��Email or username��6:    �� Left$ 10��6V   
 �� Top$ 54��6g   $��Center=�6w   $��71,10,108,0q�6�   $	��113��6�   �� 5   
   -   5        $ myEmailText��5   U   $��30��6k   $
 Wrap=�6w   $��5q�6�   $��Email or username��6�   $	��150��6�   $��Italic$�6�   ��6�   Z� 6�   �� 5   
   -   5        $ myPasswordLabel��5   $   $y�Hidden=�6   $��Password��6=   $��Center=�6Q   $��71,10,127,0q�6n   $��94��6�   �� 5   
   -   5        $ myPasswordText��5   [   $��30��6t   $
 Wrap=�6�   $��Password��6�   $��5q�6�   $	��150��6�   $��Italic$�6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ myDierctoryButton��5      $��Change Directory��6-   $	��102��6H   $	 180��6T   $	 389��6f   $��0, 15, 0, 0q�6w   6�   �� 5   
   -	   5        $ mySaveButton��5      $
��Save��6'   $��75��66   $	 307��6A   $	 389��6S   $��0, 10, 0, 0q�6d   {�.  6�   �� 5   
   -
   5        $��
clear path��5      $y�Hidden=�6&   6:   5      5      