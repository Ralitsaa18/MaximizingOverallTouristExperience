using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MaximizingOverallTouristExperience
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Landmark> landmarkDictionary;
        private List<Landmark> selectedLandmarks;
        private GMapOverlay markersOverlay;

        public Form1()
        {
            InitializeComponent();
            InitializeMap();
            InitializeLandmarkDictionary();
            selectedLandmarks = new List<Landmark>();
        }

        private void InitializeMap()
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(42.7660, 25.2384);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 7;
            gMapControl1.Dock = DockStyle.Fill;

            markersOverlay = new GMapOverlay("markers");
            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void InitializeLandmarkDictionary()
        {
            landmarkDictionary = new Dictionary<string, Landmark>
            {
                { "Национален музей на българската литература", new Landmark("Национален музей на българската литература", 42.6975, 23.4242, 4.5) },
                { "Катедрала Свети Александър Невски", new Landmark("Катедрала Свети Александър Невски", 42.6957, 23.2322, 4.7) },
                { "Шипка", new Landmark("Шипка", 42.7284, 25.3386, 4.9) },
                { "Нос Калиакра", new Landmark("Нос Калиакра", 43.3622, 28.4383, 4.7) },
                { "Лесопарк Хисарлъка", new Landmark("Лесопарк Хисарлъка", 42.2757, 22.6918, 4.7) },
                { "Бачковски манастир", new Landmark("Бачковски манастир", 41.9421, 24.8497, 4.8) },
                { "Пещера Съева дупка", new Landmark("Пещера Съева дупка", 43.0469, 24.1859, 4.8) },
                { "Музей на розата", new Landmark("Музей на розата", 42.6339, 25.2448, 4.4) },
                { "Морска градина Варна", new Landmark("Морска градина Варна", 43.2141, 27.9147, 4.0) },
                { "Рилски манастир", new Landmark("Рилски манастир", 41.8236, 23.4855, 5.0) },
                { "Етъра", new Landmark("Етъра", 42.8089, 25.3484, 4.0) },
                { "Оборище", new Landmark("Оборище", 42.5288, 24.1146, 3.0) },
                { "Къща-музей Райна Княгиня", new Landmark("Къща-музей Райна Княгиня", 42.5068, 24.1838, 4.7) },
                { "Клисура", new Landmark("Клисура", 42.6939, 24.4493, 4.4) },
                { "Троянски манастир", new Landmark("Троянски манастир", 42.8775, 24.7765, 4.8) },
                { "Седемте рилски езера", new Landmark("Седемте рилски езера", 42.2018, 23.3091, 4.8) },
                { "Пещера Леденика", new Landmark("Пещера Леденика", 43.2046, 23.4930, 4.7) },
                { "Чудните мостове", new Landmark("Чудните мостове", 42.1585, 24.7509, 4.8) },
                { "Музей на образованието", new Landmark("Музей на образованието", 42.8707, 25.3166, 4.6) },
                { "Асенова крепост", new Landmark("Асенова крепост", 41.9865, 24.8730, 4.7) },
                { "Национален музей - Земята и хората", new Landmark("Национален музей - Земята и хората", 42.6801, 23.3209, 4.6) },
                { "Храм Света София", new Landmark("Храм Света София", 42.6964, 23.3310, 4.7) },
                { "Манастир 7-те престола", new Landmark("Манастир 7-те престола", 42.9996, 23.4724, 4.8) },
                { "Пещера Магурата", new Landmark("Пещера Магурата", 43.7271, 22.5787, 4.5) },
                { "Белоградчишки скали", new Landmark("Белоградчишки скали", 43.6234, 22.6765, 4.6) },
                { "Музей-крепост Баба Вида", new Landmark("Музей-крепост Баба Вида", 43.9930, 22.8866, 4.7) },
                { "Ягодинската пещера", new Landmark("Ягодинската пещера", 41.6750, 24.6908, 4.8) },
                { "Рупите", new Landmark("Рупите", 41.4590, 23.2642, 4.6) },
                { "Самуилова крепост", new Landmark("Самуилова крепост", 41.3945, 23.02914, 4.5) },
                { "Кордопулова къща", new Landmark("Кордопулова къща", 41.5230, 23.3983, 4.7) },
                { "Архитектурно исторически резерват - Мелник", new Landmark("Архитектурно исторически резерват - Мелник", 41.5227, 23.3927, 4.5) },
                { "Специализиран музей на резбарското и етнографско изкуство", new Landmark("Специализиран музей на резбарското и етнографско изкуство", 42.8695, 25.4959, 4.1) },
                { "Царевец", new Landmark("Царевец", 43.0830, 25.6524, 4.7) },
                { "Арбанаси", new Landmark("Арбанаси", 43.0978, 25.6683, 4.6) },
                { "Къща-музей Алеко Константинов", new Landmark("Къща-музей Алеко Константинов", 43.6204, 25.3400, 4.7) },
                { "Пантеон на възрожденците", new Landmark("Пантеон на възрожденците", 43.8505, 25.9607, 4.5) },
                { "Исторически музей - Исперих", new Landmark("Исторически музей - Исперих", 43.7151, 26.8283, 4.4) },
                { "Голяма базилика в Плиска", new Landmark("Голяма базилика в Плиска", 43.3987, 27.13893, 4.8) },
                { "Мадарският конник", new Landmark("Мадарският конник", 43.2771, 27.1192, 4.8) },
                { "Златната църква", new Landmark("Златната църква", 43.1459, 26.8138, 4.8) },
                { "Музей на солта", new Landmark("Музей на солта", 42.5656, 27.6315, 4.4) },
                { "Историческа местност Петрова Нива", new Landmark("Историческа местност Петрова Нива", 42.0354, 27.5159, 4.2) },
                { "Историческият музей в Малко Търново", new Landmark("Историческият музей в Малко Търново", 41.9806, 27.5238, 4.0) },
                { "Перперикон", new Landmark("Перперикон", 41.7151, 25.4650, 3.0) },
                { "Буйновско ждрело", new Landmark("Буйновско ждрело", 41.6593, 24.3416, 4.0) },
                { "Пещера Ухловица", new Landmark("Пещера Ухловица", 41.5166, 24.6666, 3.0) },
                { "Село Широка лъка", new Landmark("Село Широка лъка", 41.6789, 24.5826, 4.0) },
                { "Връх Голям Перелик", new Landmark("Връх Голям Перелик", 41.6049, 24.5743, 3.0) },
                { "Връх Снежанка", new Landmark("Връх Снежанка", 41.6365, 24.6778, 4.0) },
                { "Пещера Дяволското гърло", new Landmark("Пещера Дяволското гърло", 41.6124, 24.3809, 3.0) },
                { "Пещера Снежанка", new Landmark("Пещера Снежанка", 42.0041, 24.2789, 4.0) },
                { "Исторически музей Перущица", new Landmark("Исторически музей Перущица", 42.0557, 24.5447, 3.0) },
                { "Връх Мусала", new Landmark("Връх Мусала", 42.1791, 23.5850, 4.0) },
                { "Връх Руен", new Landmark("Връх Руен", 42.1580, 22.5162, 3.0) },
                { "Дряновски манастир", new Landmark("Дряновски манастир", 42.9508, 25.4319, 4.0) }
            };
        }

        private void btnAddSpot_Click(object sender, EventArgs e)
        {
            string spotName = txtSpotName.Text;
            if (landmarkDictionary.TryGetValue(spotName, out var landmark))
            {
                selectedLandmarks.Add(landmark);
                AddLandmarkToMap(landmark);
                MessageBox.Show($"{spotName} беше добавена на картата.", "Успешно добавяне", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Забележителността не беше намерена в библиотеката.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnShortestRoute_Click(object sender, EventArgs e)
        {
            if (selectedLandmarks.Count < 2)
            {
                MessageBox.Show("Моля, добавете поне две забележителности.", "Недостатъчно забележителности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Landmark startingLandmark = selectedLandmarks[0];
            txtStartingPoint.Text = startingLandmark.Name;

            var shortestRoute = PrimsAlgorithm(selectedLandmarks);
            DisplayRouteOnMap(shortestRoute);

            var routeDescription = string.Join(" -> ", shortestRoute.Select(edge => edge.To.Name));
            txtRoute.Text = routeDescription;
        }


        private void btnAlternativeRoute_Click(object sender, EventArgs e)
        {
            if (selectedLandmarks.Count < 2)
            {
                MessageBox.Show("Моля, добавете поне две забележителности.", "Недостатъчно забележителности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var alternativeRoute = GetAlternativeRoute();
            if (alternativeRoute == null)
            {
                MessageBox.Show("Няма наличен алтернативен маршрут.", "Няма алтернативи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DisplayRouteOnMap(alternativeRoute);
                var routeDescription = string.Join(" -> ", alternativeRoute.Select(edge => edge.To.Name));
                txtRoute.Text = routeDescription;
            }
        }

        private List<Edge> PrimsAlgorithm(List<Landmark> landmarks)
        {
            var edges = new List<Edge>();
            var selectedLandmarks = new HashSet<Landmark>();
            var availableEdges = new SortedSet<Edge>(Comparer<Edge>.Create((a, b) => a.Distance.CompareTo(b.Distance)));

            if (landmarks.Count == 0)
                return edges;

            selectedLandmarks.Add(landmarks[0]);
            foreach (var otherLandmark in landmarks.Skip(1))
            {
                availableEdges.Add(new Edge
                {
                    From = landmarks[0],
                    To = otherLandmark,
                    Distance = GetDistance(landmarks[0], otherLandmark)
                });
            }

            while (selectedLandmarks.Count < landmarks.Count && availableEdges.Any())
            {
                var shortestEdge = availableEdges.First();
                availableEdges.Remove(shortestEdge);

                if (selectedLandmarks.Contains(shortestEdge.To))
                    continue;

                edges.Add(shortestEdge);
                selectedLandmarks.Add(shortestEdge.To);

                foreach (var otherLandmark in landmarks)
                {
                    if (!selectedLandmarks.Contains(otherLandmark))
                    {
                        availableEdges.Add(new Edge
                        {
                            From = shortestEdge.To,
                            To = otherLandmark,
                            Distance = GetDistance(shortestEdge.To, otherLandmark)
                        });
                    }
                }
            }

            return edges;
        }




        private List<Edge> GetAlternativeRoute()
        {
            var originalRoute = PrimsAlgorithm(selectedLandmarks);
            var alternativeRoute = new List<Edge>(originalRoute);
            bool alternativeFound = false;

            foreach (var edge in originalRoute)
            {
                var nearbyLandmarks = landmarkDictionary.Values
                    .Where(l => GetDistance(l, edge.To) < 50000 && l.Rating > edge.To.Rating && !selectedLandmarks.Contains(l))
                    .ToList();

                if (nearbyLandmarks.Any())
                {
                    var betterLandmark = nearbyLandmarks.OrderByDescending(l => l.Rating).First();
                    var dialogResult = MessageBox.Show($"Има по-високо оценена забележителност в близост: " +
                        $"{betterLandmark.Name}. Искате ли да замените {edge.To.Name} с {betterLandmark.Name}?", "Намерена алтернатива", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        alternativeRoute.Remove(edge);
                        alternativeRoute.Add(new Edge
                        {
                            From = edge.From,
                            To = betterLandmark,
                            Distance = GetDistance(edge.From, betterLandmark)
                        });
                        alternativeFound = true;

                        // Премахване на старата забележителност от картата и списъка
                        RemoveLandmarkFromMap(edge.To);
                        selectedLandmarks.Remove(edge.To);

                        // Добавяне на новата забележителност към списъка и картата
                        selectedLandmarks.Add(betterLandmark);
                        AddLandmarkToMap(betterLandmark);

                        // Прекъсване на цикъла, за да начертаем маршрута след всяка замяна
                        break;
                    }
                }
            }

            if (alternativeFound)
            {
                // Начертаване на маршрута веднага след замяна
                var newRoute = PrimsAlgorithm(selectedLandmarks);
                DisplayRouteOnMap(newRoute);
            }

            return alternativeFound ? PrimsAlgorithm(selectedLandmarks) : null;
        }

        private void RemoveLandmarkFromMap(Landmark landmark)
        {
            var markerToRemove = markersOverlay.Markers
                .FirstOrDefault(m => m.Position.Lat == landmark.Latitude && m.Position.Lng == landmark.Longitude);
            if (markerToRemove != null)
            {
                markersOverlay.Markers.Remove(markerToRemove);
                gMapControl1.Refresh();
            }
        }


        private void AddLandmarkToMap(Landmark landmark)
        {
            var point = new PointLatLng(landmark.Latitude, landmark.Longitude);
            var marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot)
            {
                ToolTipText = $"{landmark.Name} (Rating: {landmark.Rating})"
            };
            markersOverlay.Markers.Add(marker);
            gMapControl1.Refresh();
        }



        private double GetDistance(Landmark from, Landmark to)
        {
            var d1 = from.Latitude * (Math.PI / 180.0);
            var num1 = from.Longitude * (Math.PI / 180.0);
            var d2 = to.Latitude * (Math.PI / 180.0);
            var num2 = to.Longitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6378137.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        private void DisplayRouteOnMap(List<Edge> route)
        {
            var routeOverlay = new GMapOverlay("route");
            foreach (var edge in route)
            {
                var points = new List<PointLatLng>
        {
            new PointLatLng(edge.From.Latitude, edge.From.Longitude),
            new PointLatLng(edge.To.Latitude, edge.To.Longitude)
        };
                var routeSegment = new GMapRoute(points, $"{edge.From.Name} to {edge.To.Name}")
                {
                    Stroke = new Pen(Color.Blue, 3)
                };
                routeOverlay.Routes.Add(routeSegment);
            }
            gMapControl1.Overlays.Clear(); // Изчистване на старите маршрути и маркери
            gMapControl1.Overlays.Add(markersOverlay); // Добавяне на всички маркери
            gMapControl1.Overlays.Add(routeOverlay); // Добавяне на новия маршрут
            gMapControl1.Refresh();
        }

    }

    public class Landmark
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Rating { get; set; }

        public Landmark(string name, double latitude, double longitude, double rating)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Rating = rating;
        }
    }

    public class Edge
    {
        public Landmark From { get; set; }
        public Landmark To { get; set; }
        public double Distance { get; set; }
    }
}
