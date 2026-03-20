using Spectre.Console;

namespace SpectreConsole;

class Program
{
    static void Main(string[] args)
    {
        // Colors, symbols, interpolation
        var fileName = "Authentication.cs";
        var dependency = "Newtonsoft.Json";
  
        AnsiConsole.MarkupLine("[green]✓ Build completed successfully[/]");
        AnsiConsole.MarkupLineInterpolated($"[#FFA500]⚠[/] [yellow]3 warnings[/] in {fileName}");
        AnsiConsole.MarkupLineInterpolated($"[bold red]✗ Error:[/] Missing dependency '{dependency}'");
        AnsiConsole.MarkupLine("  → See: [link=https://docs.example.com/dependencies]documentation[/]");

        // Input:
        var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
        AnsiConsole.MarkupLine($"Welcome, [blue]{name}[/]!");
        
        // Menu selection:
        var size = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("What [green]size pizza[/] would you like?")
                .AddChoices("Small", "Medium", "Large", "Extra Large"));
  
        AnsiConsole.MarkupLine($"You selected: [yellow]{size}[/]");
        
        // Select toppings:
        

        var toppings = AnsiConsole.Prompt(
            new MultiSelectionPrompt<string>()
                .Title("What [green]toppings[/] would you like?")
                .NotRequired()
                .InstructionsText("[grey](Press [blue]<space>[/] to toggle, [green]<enter>[/] to confirm)[/]")
                .AddChoices("Pepperoni", "Mushrooms", "Sausage",
                    "Onions", "Green Peppers", "Black Olives",
                    "Extra Cheese", "Bacon", "Pineapple"));
  
        if (toppings.Count == 0)
        {
            AnsiConsole.MarkupLine("A plain cheese pizza - classic choice!");
        }
        else
        {
            AnsiConsole.MarkupLine($"Toppings: [yellow]{string.Join(", ", toppings)}[/]");
        }
        
        // Confirm order:
        var confirmed = AnsiConsole.Confirm("Place this order?");
  
        if (confirmed)
        {
            AnsiConsole.MarkupLine("[green]Order placed![/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[yellow]Order cancelled.[/]");
        }
    }
}