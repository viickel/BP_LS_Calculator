Imports System.Xml


Public Class Form1

    Public Class CombattantStats
        Public PointsCotation As Integer = 0
        Public NbVictoires As Integer = 0
        Public SommePoints As Integer = 0
        Public TieBreaker As Long = 0


        ' Méthode pour ajouter des points de cotation et mettre à jour les statistiques
        Public Sub AjouterPoints(scoreGagnant As Integer, scorePerdant As Integer)

            NbVictoires += 1
            SommePoints += scoreGagnant

            Dim difference As Integer = Math.Abs(scoreGagnant - scorePerdant)
            If difference = 1 Then
                PointsCotation += 1
                TieBreaker += 1
            ElseIf difference >= 4 AndAlso difference <= 7 Then
                PointsCotation += 2
                TieBreaker += 100
            ElseIf difference >= 8 AndAlso difference <= 11 Then
                PointsCotation += 3
                TieBreaker += 10000
            ElseIf difference >= 12 Then
                PointsCotation += 4
                TieBreaker += 1000000
            End If
        End Sub
    End Class

    Public Class CombatantInfo
        Public ID As String
        Public Nom As String
        Public Prenom As String
        Public NumLicence As String
        Public Stats As New CombattantStats()
    End Class



    Public ListeCombatants As New List(Of CombatantInfo)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.Filter = "Fichiers BellePoule (*.cotcot)|*.cotcot|Tous les fichiers (*.*)|*.*"
        OpenFileDialog.Title = "Sélectionnez un fichier .cotcot"

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Dim sCheminFichier As String = OpenFileDialog.FileName
            ListeCombatants.Clear()
            CotcotReader(sCheminFichier)


        End If

    End Sub



    Private Sub CotcotReader(sFilePath As String)
        Try
            Dim settings As New XmlReaderSettings()
            settings.DtdProcessing = DtdProcessing.Parse

            Using reader As XmlReader = XmlReader.Create(sFilePath, settings)
                Dim iNbTour As Integer = 0

                ' Se déplacer jusqu'à l'élément <Tireurs>
                If reader.ReadToFollowing("Tireurs") Then
                    ' Lire les éléments <Tireur> à l'intérieur de <Tireurs>
                    While reader.Read()
                        If reader.NodeType = XmlNodeType.Element AndAlso reader.Name = "Tireur" Then
                            Dim nouveauCombattant As New CombatantInfo() With {
                            .ID = reader.GetAttribute("ID"),
                            .Nom = reader.GetAttribute("Nom"),
                            .Prenom = reader.GetAttribute("Prenom"),
                            .NumLicence = reader.GetAttribute("Licence")
                        }
                            ListeCombatants.Add(nouveauCombattant)
                        ElseIf reader.NodeType = XmlNodeType.EndElement AndAlso reader.Name = "Tireurs" Then
                            ' Sortir de la boucle une fois que l'élément </Tireurs> est atteint
                            Exit While
                        End If
                    End While
                End If

                '-----------------------------------------------------------------------------------------------------

                ' Se déplacer jusqu'à l'élément <TourDePoules>
                If reader.ReadToFollowing("TourDePoules") Then
                    ' Parcourir les éléments <Poule>
                    While reader.ReadToFollowing("Poule")
                        ' Lire les matchs à l'intérieur de chaque <Poule>
                        Using pouleReader As XmlReader = reader.ReadSubtree()
                            pouleReader.Read() ' Avancer au premier élément à l'intérieur de <Poule>
                            While pouleReader.Read()
                                If pouleReader.NodeType = XmlNodeType.Element AndAlso pouleReader.Name = "Match" Then
                                    Dim idMatch As String = pouleReader.GetAttribute("ID")
                                    Console.WriteLine($"Lecture du match ID: {idMatch}")

                                    Dim tireur1Ref As String = ""
                                    Dim tireur1Score As Integer = -1
                                    Dim tireur2Ref As String = ""
                                    Dim tireur2Score As Integer = -1

                                    ' Lire les informations des tireurs dans le match
                                    Using matchReader As XmlReader = pouleReader.ReadSubtree()
                                        matchReader.Read()
                                        While matchReader.ReadToFollowing("Tireur")
                                            Dim refTireurMatch As String = matchReader.GetAttribute("REF")
                                            Dim scoreStr As String = matchReader.GetAttribute("Score")
                                            Dim statutTireur As String = matchReader.GetAttribute("Statut")
                                            Dim score As Integer

                                            If Not String.IsNullOrEmpty(refTireurMatch) AndAlso Integer.TryParse(scoreStr, score) Then
                                                If tireur1Ref = "" Then
                                                    tireur1Ref = refTireurMatch
                                                    tireur1Score = score
                                                Else
                                                    tireur2Ref = refTireurMatch
                                                    tireur2Score = score
                                                End If

                                                If statutTireur.ToUpper() = "V" Then
                                                    Dim combattantVainqueur = ListeCombatants.FirstOrDefault(Function(c) c.ID = refTireurMatch)
                                                    If combattantVainqueur IsNot Nothing Then
                                                        Dim refPerdant As String = If(refTireurMatch = tireur1Ref, tireur2Ref, tireur1Ref)
                                                        Dim scorePerdant As Integer = If(refTireurMatch = tireur1Ref, tireur2Score, tireur1Score)
                                                        combattantVainqueur.Stats.AjouterPoints(score, scorePerdant)
                                                        Console.WriteLine($"  Le tireur {refTireurMatch} (ID) a gagné contre {refPerdant} ({scorePerdant}).")
                                                    End If
                                                End If
                                            End If
                                        End While
                                    End Using
                                End If
                            End While
                        End Using
                    End While
                End If



                AffichageDataGrid()





            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la lecture du fichier : " & ex.Message, "Erreur")
        End Try
    End Sub



    Public Sub AffichageDataGrid()

        If Me.DataGridView1 IsNot Nothing Then
            ' Trier la liste des combattants en utilisant une fonction de comparaison personnalisée
            ListeCombatants.Sort(Function(c1 As CombatantInfo, c2 As CombatantInfo)
                                     ' Comparer par PointsCotation (ordre décroissant)
                                     Dim comparison As Integer = c2.Stats.PointsCotation.CompareTo(c1.Stats.PointsCotation)
                                     If comparison <> 0 Then
                                         Return comparison
                                     End If

                                     ' Si PointsCotation est égal, comparer par NbVictoires (ordre décroissant)
                                     comparison = c2.Stats.NbVictoires.CompareTo(c1.Stats.NbVictoires)
                                     If comparison <> 0 Then
                                         Return comparison
                                     End If

                                     ' Si NbVictoires est égal, comparer par SommePoints (ordre décroissant)
                                     comparison = c2.Stats.SommePoints.CompareTo(c1.Stats.SommePoints)
                                     If comparison <> 0 Then
                                         Return comparison
                                     End If

                                     ' Si SommePoints est égal, comparer par TieBreaker (ordre décroissant)
                                     Return c2.Stats.TieBreaker.CompareTo(c1.Stats.TieBreaker)
                                 End Function)


            ' Empêcher l'édition des cellules
            Me.DataGridView1.ReadOnly = True
            ' Empêcher l'ajout de nouvelles lignes par l'utilisateur (via l'interface)
            Me.DataGridView1.AllowUserToAddRows = False
            ' Empêcher la suppression de lignes par l'utilisateur (via l'interface)
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.Columns.Clear() ' Efface les colonnes existantes

            ' Ajoute les colonnes manuellement
            Me.DataGridView1.Columns.Add("Classement", "Classement")
            Me.DataGridView1.Columns.Add("Nom", "Nom")
            Me.DataGridView1.Columns.Add("Prenom", "Prénom")
            Me.DataGridView1.Columns.Add("NumLicence", "Licence")
            Me.DataGridView1.Columns.Add("PointsCotation", "Cotation")
            Me.DataGridView1.Columns.Add("NbVictoires", "NbVictoires")
            Me.DataGridView1.Columns.Add("SommePoints", "SommePoints")
            Me.DataGridView1.Columns.Add("TieBreaker", "TieBreaker")

            ' Remplis les lignes avec les données de ListeCombatants
            For i As Integer = 0 To ListeCombatants.Count - 1
                Dim combattant As CombatantInfo = ListeCombatants(i)
                Me.DataGridView1.Rows.Add(i + 1, combattant.Nom, combattant.Prenom, combattant.NumLicence,
                                           combattant.Stats.PointsCotation, combattant.Stats.NbVictoires,
                                           combattant.Stats.SommePoints, combattant.Stats.TieBreaker)
            Next


        End If
    End Sub

End Class
