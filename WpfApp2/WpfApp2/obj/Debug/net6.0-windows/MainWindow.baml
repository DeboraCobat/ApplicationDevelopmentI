   M S B A M L   `   `   `  ����  WpfApp2    WpfApp2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $
��0,10q�6X   .+�5      �� -   5         ��Name$ btnRead��5      $
��Read��6&   $��5q�6K   �� 5      -   5        $ btnCount��5      $��Count��6'   $��5q�6N   �� 5      -   5        $ btnWrite��5      $��Write��6'   $��5q�6N   �� 5      -   5        $ 	btnUpload��5      $��Upload��6(   $��5q�6Q   �� 5      -   5        $ btnExit��5      $
��Exit��6&   $��5q�6K   5      �� 5   
   -   5         ��Name$ textBox1��5      $��1��6$    �� TextWrapping$
 Wrap=�61   $	��Top=�6E   $��10q�6]    �� 
IsReadOnly$
 True��6i   �� 5   
   -   5        $ textBox2��5      $��1��6$   $
 Wrap=�61   $	��Top=�6E   $��10,40,10,10q�6]   �� 5   
   -   5         ��Name$ label1��5      $��1��6    $
��Left=�6-   $	��Top=�6H   $��	10,70,0,0q�6`   �� 5   
   -	   5         ��Name$ richTextBox1��5      $��1��6,   $��Stretch=�69   $��10,100,10,10q�6U   5      5      