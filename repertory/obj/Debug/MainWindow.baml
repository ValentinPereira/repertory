   M S B A M L   `   `   `  ����D  @repertory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:repertory	repertory  5   	       repertory.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:repertory     5   	     � Title$  
Formulaire��5   	   $	��600��6   $	��800��6)   .��5	      � 
�������.+�5   
   �� $
��Wrap=�6   $��Répertoire��6(    �� TextAlignment$ Center=�6:   $��24(�6Q   $
��Bold"�6_   $��Trebuchet MS)�6q   $��303,10,292,523q�6�   
���   �6�   �� 5   
   $��34��6   $��Center=�6   $��Center=�69   $��Nom de utilisateur��6T   $��18(�6q   $
��Bold"�6   $��Trebuchet MS)�6�   $��206,67,392,469q�6�   
�������
���   � J� RenderTransformOrigin$ 1.446,0.794&�6�   $	��194��6  �� 5   
   -   5         ��Name$ textboxLastname��5      $��435,67,170,468q�6+   �� 5   
   -   5         ��Name$# TextBlockLastnameErrorMessage��5      $�� ��6;   $��206,107,218,442q�6C   
���  ��6\   �� 5   
   $��34��6   $��Right=�6   $��Center=�68   $��Prénom de utilisateur��6S   $��18(�6s   $
��Bold"�6�   $��Trebuchet MS)�6�   $��0,152,392,384q�6�   
�������
���   �$	��198��6�   �� 5   
   -   5        $ textboxFirstname��5      $��435,151,170,384q�6,   �� 5   
   -   5        $$ TextBlockFirstnameErrorMessage��5      $��206,195,247,355q�6<   
���  ��5      �� 5   
   $��34��6   $��Right=�6   $��Center=�68   $��Nom d'utilisateur��6S   $��18(�6o   $��Trebuchet MS)�6}   $��0,225,392,311q�6�   
�������
���   �$	��198��6�   �� 5   
   -   5        $ textboxUsername��5      $��435,224,170,311q�6+   �� 5   
   -   5        $# TextBlockUsernameErrorMessage��5      $��202,264,242,284q�6;   
���  ��6T   �� 5   
   $��34��6   $��Center=�6   $��Center=�69   $��Adresse mail��6T   $��18(�6k   $��Trebuchet MS)�6y   $��206,297,392,239q�6�   
�������
���   �$	��194��6�   �� 5   
   -   5        $ textboxMail��5      $��435,297,170,239q�6'   �� 5   
   -   5        $ TextBlockMailErrorMessage��5      $��206,336,238,218q�67   
���  ��6P   �� 5   
   $��34��6   $��Center=�6   $��Center=�69   $��Mot de passe��6T   $��18(�6k   $��Trebuchet MS)�6y   $��206,372,392,164q�6�   
�������
���   �$	��194��6�   G� 5   
   -	   5         G�Name$ passboxPassword��5       G� PasswordChar$ *��6/   $��435,367,170,169q�6@   �� 5   
   -
   5        $# TextBlockPasswordErrorMessage��5      $��206,411,238,143q�6;   
���  ��6T   �� 5   
   $��34��6   $��Center=�6   $��Center=�67   $"��Confirmation du mot de passe��6T   $��18(�6{   $��Trebuchet MS)�6�   
�������$��150,439,392,97q�6�   
���   �$	��250��6�   $ 0.921,10.735&�6�   G� 5   
   -   5        $ passboxPasswordC��5      $ *��60   $��435,439,170,98q�6A   �� 5   
   -   5        $$ TextBlockPasswordCErrorMessage��5      $��202,477,242,75q�6<   
���  ��$ 0.5,0.5&�6e   �� 5   
   -   5         ��Name$ btnConnexion��5      $��	Connexion��6'   $��409,516,218,-1q�6;   
�������$��18(�6�   ��5       �� 5!       �� Color$ Black��6"   	 �� Opacity$		 0.8Q�60   5#      �� 5$   
   -   5        $ btnRegister��5$      $��Inscription��6&   $��Trebuchet MS)�6<   
�������$��232,516,392,0q�6i   $��18(�6�   ��5%      �� 5&      $ Black��6"   $		 0.8Q�60   5(      5)      5*      