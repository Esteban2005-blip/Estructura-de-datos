
public class Paciente
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public DateTime FechaTurno { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Cédula: {Cedula}, Turno: {FechaTurno}";
    }
}

public class AgendaTurnos
{
    private List<Paciente> pacientes = new List<Paciente>();

    public void AgregarPaciente(Paciente p)
    {
        pacientes.Add(p);
        Console.WriteLine("Turno registrado correctamente.\n");
    }

    public void MostrarTurnos()
    {
        if (pacientes.Count == 0)
        {
            Console.WriteLine("No hay turnos registrados.\n");
            return;
        }

        Console.WriteLine("Turnos registrados:");
        foreach (var p in pacientes)
        {
            Console.WriteLine(p);
        }
    }

    public void BuscarPorCedula(string cedula)
    {
        var encontrado = pacientes.Find(p => p.Cedula == cedula);
        if (encontrado != null)
            Console.WriteLine($"Paciente encontrado: {encontrado}\n");
        else
            Console.WriteLine("Paciente no encontrado.\n");
    }
}

class Program
{
    static void Main()
    {
        AgendaTurnos agenda = new AgendaTurnos();
        int opcion;

        do
        {
            Console.WriteLine("Agenda de Turnos - Clínica");
            Console.WriteLine("1. Agregar turno");
            Console.WriteLine("2. Ver todos los turnos");
            Console.WriteLine("3. Buscar por cédula");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Paciente p = new Paciente();
                    Console.Write("Ingrese nombre: ");
                    p.Nombre = Console.ReadLine();
                    Console.Write("Ingrese cédula: ");
                    p.Cedula = Console.ReadLine();
                    Console.Write("Ingrese fecha y hora del turno (yyyy-MM-dd HH:mm): ");
                    p.FechaTurno = DateTime.Parse(Console.ReadLine());
                    agenda.AgregarPaciente(p);
                    break;
                case 2:
                    agenda.MostrarTurnos();
                    break;
                case 3:
                    Console.Write("Ingrese cédula del paciente: ");
                    string cedula = Console.ReadLine();
                    agenda.BuscarPorCedula(cedula);
                    break;
                case 4:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 4);
    }
}
