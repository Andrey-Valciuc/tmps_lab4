# TMPS_LAB4

# Behavioral design patterns:
Modelele de design comportamental se ocupă de algoritmi și de atribuirea responsabilităților între obiecte.În cadrul acestui proiect au fost implementate următoarele modele:

1. Observer
2. Strategy
3. Command
4. Template

# 1. Observer
Modelul Observer stabilește o relație de tip unu-la-mulți între obiecte, în care mai mulți observatori sunt interesați să fie notificați de schimbări sau evenimente într-un subiect.În secvența de cod de mai jos, interfața IObserver declară metoda Update pe care observatorii o implementează pentru a primi actualizări. Interfața ISubject definește metodele pentru înregistrarea, eliminarea și notificarea observatorilor. Clasa MusicLibrary implementează interfața ISubject și menține o listă de observatori. Clasa User implementează interfața IObserver și primește notificări prin metoda Update. Metoda NotifyObservers este apelată în clasa MusicLibrary pentru a notifica toți observatorii înregistrați atunci când este adăugat un cântec nou.

```
public interface IObserver
{
     void Update(string songName);
}
public interface ISubject
{
     void RegisterObserver(IObserver observer);
     void RemoveObserver(IObserver observer);
     void NotifyObservers(string songName);
}
public class MusicLibrary : ISubject
{
     private List<IObserver> observers;
     // ...

     public void RegisterObserver(IObserver observer)
     {
          observers.Add(observer);
     }

     public void RemoveObserver(IObserver observer)
     {
          observers.Remove(observer);
     }

     public void NotifyObservers(string songName)
     {
          foreach (var observer in observers)
          {
               observer.Update(songName);
          }
     }
     // ...
}
public class User : IObserver
{
     // ...

     public void Update(string songName)
     {
          Console.WriteLine($"User '{name}' received a notification: New song added - {songName}");
     }
}

```
# 2. Strategy
 Modelul Strategy este un model de design comportamental care ne permite să definim o familie de algoritmi, să îi punem pe fiecare într-o clasă separată și să facem obiectele lor interschimbabile.În codul prezentat mai jos, interfața IStrategy declară metoda Sort pe care strategiile de sortare o implementează. Clasele AlphabeticalSortStrategy și ReleaseDateSortStrategy implementează interfața IStrategy și oferă diferite strategii de sortare. Clasa SortCommand reprezintă o comandă pentru a sorta melodiile dintr-o bibliotecă de muzică și primește un obiect strategie ca parametru. Clasa SortCommand execută operația de sortare prin apelarea metodei Sort a strategiei specificate.
 
```
public interface IStrategy
{
     void Sort(List<string> songs);
}
public class AlphabeticalSortStrategy : IStrategy
{
     public void Sort(List<string> songs)
     {
          songs.Sort();
     }
}
public class ReleaseDateSortStrategy : IStrategy
{
     public void Sort(List<string> songs)
     {
          // Perform sorting based on release date
          // ...
     }
}
public class SortCommand : ICommand
{
     // ...

     public void Execute()
     {
          strategy.Sort(musicLibrary.GetSongs());
     }
}

```
# 3. Command
Modelul Command este un model de design comportamental care transformă o cerere într-un obiect independent care conține toate informațiile despre cerere. Această transformare ne permite să transmitem cererile ca argumente de metode. În secvența de mai jos, interfața ICommand declară metoda Execute pe care obiectele de comandă trebuie să o implementeze. Clasa SortCommand implementează interfața ICommand și reprezintă o comandă pentru a sorta melodiile dintr-o bibliotecă de muzică. Aceasta primește un obiect MusicLibrary și un obiect IStrategy (strategie de sortare) ca parametri de constructor. Metoda Execute a clasei SortCommand este responsabilă de executarea comenzii prin invocarea metodei Sort a strategiei specificate.
```
public interface ICommand
{
     void Execute();
}

public class SortCommand : ICommand
{
     private MusicLibrary musicLibrary;
     private IStrategy strategy;

     public SortCommand(MusicLibrary musicLibrary, IStrategy strategy)
     {
          this.musicLibrary = musicLibrary;
          this.strategy = strategy;
     }

     public void Execute()
     {
          strategy.Sort(musicLibrary.GetSongs());
     }
}

```
# 4. Template
Modelul Template Method definește scheletul unui algoritm într-o clasă de bază, dar permite subclaselor să suprascrie pașii specifici ai algoritmului.Clasa MusicLibraryDisplayTemplate este o clasă abstractă care furnizează structura generală pentru afișarea unei biblioteci de muzică. Aceasta definește metoda template DisplayMusicLibrary, care apelează alte metode abstracte sau non-abstracte. Metoda SortSongs este declarată ca fiind abstractă, permițând subclaselor să furnizeze propria implementare pentru sortarea melodiilor. Metoda ShowSongs este declarată ca fiind virtuală, furnizând o implementare implicită, dar permițând subclaselor să o suprascrie în cazul în care este necesar.
```
public abstract class MusicLibraryDisplayTemplate
{
     public void DisplayMusicLibrary(MusicLibrary musicLibrary)
     {
          var sortedSongs = SortSongs(musicLibrary);
          ShowSongs(sortedSongs);
     }

     protected abstract List<string> SortSongs(MusicLibrary musicLibrary);

     protected virtual void ShowSongs(List<string> songs)
     {
          Console.WriteLine("Sorted Songs:");
          foreach (var song in songs)
          {
               Console.WriteLine(song);
          }
     }
}

public class ConsoleMusicLibraryDisplayTemplate : MusicLibraryDisplayTemplate
{
     // ...

     protected override List<string> SortSongs(MusicLibrary musicLibrary)
     {
          // Use a specific sorting strategy
          // ...
          return musicLibrary.GetSongs();
     }

     protected override void ShowSongs(List<string> songs)
     {
          Console.WriteLine("Songs in the Music Library:");
          foreach (var song in songs)
          {
               Console.WriteLine(song);
          }
     }
}

```
