﻿using System;
using System.Collections.Generic;

namespace MiPracticaDataFirst.Models;

public partial class Moneda
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Simbolo { get; set; }
}
