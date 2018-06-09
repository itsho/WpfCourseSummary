using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace WpfApplication01.Day04
{
    public partial class _04_3D : Page
    {
        public _04_3D()
        {
            InitializeComponent();
        }

        private void simpleButton_Click(object sender, RoutedEventArgs e)
        {
            MeshGeometry3D triangleMesh = new MeshGeometry3D();
            Point3D point0 = new Point3D(0, 0, 0);
            Point3D point1 = new Point3D(5, 1, 0);
            Point3D point2 = new Point3D(0, 0, 5);

            triangleMesh.Positions.Add(point0);
            triangleMesh.Positions.Add(point1);
            triangleMesh.Positions.Add(point2);
            triangleMesh.TriangleIndices.Add(0);
            triangleMesh.TriangleIndices.Add(2);
            triangleMesh.TriangleIndices.Add(1);

            Vector3D normal = new Vector3D(0, 1, 0);
            triangleMesh.Normals.Add(normal);
            triangleMesh.Normals.Add(normal);
            triangleMesh.Normals.Add(normal);

            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.Green));
            GeometryModel3D triangleModel = new GeometryModel3D(triangleMesh, material);
            ModelVisual3D model = new ModelVisual3D();
            model.Content = triangleModel;
            mainViewport.Children.Add(model);
        }

        private Model3DGroup CreateTriangleModel(Point3D p0, Point3D p1, Point3D p2)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();
            mesh.Positions.Add(p0);
            mesh.Positions.Add(p1);
            mesh.Positions.Add(p2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);

            Vector3D normal = CalculateNormal(p0, p1, p2);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);

            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.LightGreen));
            GeometryModel3D model = new GeometryModel3D(mesh, material);
            Model3DGroup group = new Model3DGroup();
            group.Children.Add(model);
            return group;
        }

        private Vector3D CalculateNormal(Point3D p0, Point3D p1, Point3D p2)
        {
            Vector3D v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
            Vector3D v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
            return Vector3D.CrossProduct(v0, v1);
        }

        private void cubeButton_Click(object sender, RoutedEventArgs e)
        {
            // a cube is a composition of 8 points in 3d world
            Model3DGroup cube = new Model3DGroup();
            Point3D p0 = new Point3D(0, 0, 0);
            Point3D p1 = new Point3D(5, 0, 0);
            Point3D p2 = new Point3D(5, 0, 5);
            Point3D p3 = new Point3D(0, 0, 5);
            Point3D p4 = new Point3D(0, 5, 0);
            Point3D p5 = new Point3D(5, 5, 0);
            Point3D p6 = new Point3D(5, 5, 5);
            Point3D p7 = new Point3D(0, 5, 5);


            // after creating these points, we will create TWO triangles to cover each side
            //front side triangles
            cube.Children.Add(CreateTriangleModel(p3, p2, p6));
            cube.Children.Add(CreateTriangleModel(p3, p6, p7));

            //right side triangles
            cube.Children.Add(CreateTriangleModel(p2, p1, p5));
            cube.Children.Add(CreateTriangleModel(p2, p5, p6));
            
            //back side triangles
            cube.Children.Add(CreateTriangleModel(p1, p0, p4));
            cube.Children.Add(CreateTriangleModel(p1, p4, p5));
            
            //left side triangles
            cube.Children.Add(CreateTriangleModel(p0, p3, p7));
            cube.Children.Add(CreateTriangleModel(p0, p7, p4));
            
            //top side triangles
            cube.Children.Add(CreateTriangleModel(p7, p6, p5));
            cube.Children.Add(CreateTriangleModel(p7, p5, p4));
            
            //bottom side triangles
            cube.Children.Add(CreateTriangleModel(p2, p3, p0));
            cube.Children.Add(CreateTriangleModel(p2, p0, p1));

            ModelVisual3D model = new ModelVisual3D();
            model.Content = cube;
            mainViewport.Children.Add(model);
        }

        private void sldCamera01_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            objCamera.LookDirection = new Vector3D(sldCamera01.Value, objCamera.LookDirection.Y, objCamera.LookDirection.Z);
        }

        private void sldCamera02_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            objCamera.LookDirection = new Vector3D(objCamera.LookDirection.X, sldCamera02.Value, objCamera.LookDirection.Z);
        }

        private void sldCamera03_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            objCamera.LookDirection = new Vector3D(objCamera.LookDirection.X, objCamera.LookDirection.Y, sldCamera03.Value);
        }

        private void sldCameraZoom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            objCamera.Position = new Point3D(sldCameraZoom.Value, objCamera.Position.Y, objCamera.Position.Z);
        }

        private void clearDisplayButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewport.Children.Clear();
        }
    }
}