   M S B A M L   `   `   `  ���� E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator      Calculator.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Calculator       � Title$  
MainWindow��$	��149��$	��478�� � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� �� $��0* �.+��� -    ��Name$ tb_function��$
��Left=�$��	10,10,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��350��$��18���� -    ��Name$ bt_calculate��$��	Calculate��$��Right=�$��	0,10,10,0q�$	��Top=�$	��100��$��20���� $	��RPN��$
��Left=�$��	10,41,0,0q�$	��Top=�$��26��$��33���� $��Result��$
��Left=�$��	10,86,0,0q�$	��Top=�$��26��$��42���� -    ��Name$ lb_rpn��$�� ��$
��Left=�$��	82,41,0,0q�$	��Top=�$��26��$	��278���� -   $ 	lb_result��$�� ��$
��Left=�$��	82,86,0,0q�$	��Top=�$��26��$	��278��