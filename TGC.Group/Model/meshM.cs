﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.Core.Direct3D;
using TGC.Core.Example;
using TGC.Core.Geometry;
using TGC.Core.Input;
using TGC.Core.Mathematica;
using TGC.Core.SceneLoader;
using TGC.Core.Shaders;
using TGC.Core.Terrain;
using TGC.Core.Textures;

namespace TGC.Group.Model
{
    class meshM
    {
        public TgcMesh crearInstanciaM1(string MediaDir)
        {
            TgcSceneLoader loader = new TgcSceneLoader();
            //ship = loader.loadSceneFromFile(MediaDir + "StarWars-Speeder-TgcScene.xml").Meshes[0];
            TgcMesh ship = loader.loadSceneFromFile(MediaDir + "XWing\\m1-TgcScene.xml").Meshes[0];
            // Al XWIN le falta una aleta.
            ship.Effect = TGCShaders.Instance.LoadEffect(MediaDir + "ShipRoll.fx");
            ship.Technique = "Normal";
            ship.Position = new TGCVector3(0, 0, 5);
            ship.Rotation = new TGCVector3(0, /*FastMath.PI / 2*/0, 0);
            ship.Transform = TGCMatrix.Scaling(TGCVector3.One * 10f) * TGCMatrix.RotationYawPitchRoll(ship.Rotation.Y, ship.Rotation.X, ship.Rotation.Z) * TGCMatrix.Translation(ship.Position);

            return ship;

        }

        public TgcMesh crearInstanciaM2(string MediaDir)
        {
            TgcSceneLoader loader = new TgcSceneLoader();
            //ship = loader.loadSceneFromFile(MediaDir + "StarWars-Speeder-TgcScene.xml").Meshes[0];
            TgcMesh ship = loader.loadSceneFromFile(MediaDir + "XWing\\m2-TgcScene.xml").Meshes[0];
            // Al XWIN le falta una aleta.
            ship.Effect = TGCShaders.Instance.LoadEffect(MediaDir + "ShipRoll.fx");
            ship.Technique = "Normal";
            ship.Position = new TGCVector3(0, 0, 5);
            ship.Rotation = new TGCVector3(0, /*FastMath.PI / 2*/0, 0);
            ship.Transform = TGCMatrix.Scaling(TGCVector3.One * 10f) * TGCMatrix.RotationYawPitchRoll(ship.Rotation.Y, ship.Rotation.X, ship.Rotation.Z) * TGCMatrix.Translation(ship.Position);

            return ship;

        }

        public TgcMesh crearInstanciaM3(string MediaDir)
        {
            TgcSceneLoader loader = new TgcSceneLoader();
            //ship = loader.loadSceneFromFile(MediaDir + "StarWars-Speeder-TgcScene.xml").Meshes[0];
            TgcMesh ship = loader.loadSceneFromFile(MediaDir + "XWing\\m3-TgcScene.xml").Meshes[0];
            // Al XWIN le falta una aleta.
            ship.Effect = TGCShaders.Instance.LoadEffect(MediaDir + "ShipRoll.fx");
            ship.Technique = "Normal";
            ship.Position = new TGCVector3(0, 0, 5);
            ship.Rotation = new TGCVector3(0, /*FastMath.PI / 2*/0, 0);
            ship.Transform = TGCMatrix.Scaling(TGCVector3.One * 10f) * TGCMatrix.RotationYawPitchRoll(ship.Rotation.Y, ship.Rotation.X, ship.Rotation.Z) * TGCMatrix.Translation(ship.Position);

            return ship;

        }

        public TgcMesh crearInstanciaM4(string MediaDir)
        {
            TgcSceneLoader loader = new TgcSceneLoader();
            //ship = loader.loadSceneFromFile(MediaDir + "StarWars-Speeder-TgcScene.xml").Meshes[0];
            TgcMesh ship = loader.loadSceneFromFile(MediaDir + "XWing\\m4-TgcScene.xml").Meshes[0];
            // Al XWIN le falta una aleta.
            ship.Effect = TGCShaders.Instance.LoadEffect(MediaDir + "ShipRoll.fx");
            ship.Technique = "Normal";
            ship.Position = new TGCVector3(0, 0, 5);
            ship.Rotation = new TGCVector3(0, /*FastMath.PI / 2*/0, 0);
            ship.Transform = TGCMatrix.Scaling(TGCVector3.One * 10f) * TGCMatrix.RotationYawPitchRoll(ship.Rotation.Y, ship.Rotation.X, ship.Rotation.Z) * TGCMatrix.Translation(ship.Position);

            return ship;

        }

        public TgcMesh crearInstanciaM5(string MediaDir)
        {
            TgcSceneLoader loader = new TgcSceneLoader();
            //ship = loader.loadSceneFromFile(MediaDir + "StarWars-Speeder-TgcScene.xml").Meshes[0];
            TgcMesh ship = loader.loadSceneFromFile(MediaDir + "XWing\\m5-TgcScene.xml").Meshes[0];
            // Al XWIN le falta una aleta.
            ship.Effect = TGCShaders.Instance.LoadEffect(MediaDir + "ShipRoll.fx");
            ship.Technique = "Normal";
            ship.Position = new TGCVector3(0, 0, 5);
            ship.Rotation = new TGCVector3(0, /*FastMath.PI / 2*/0, 0);
            ship.Transform = TGCMatrix.Scaling(TGCVector3.One * 10f) * TGCMatrix.RotationYawPitchRoll(ship.Rotation.Y, ship.Rotation.X, ship.Rotation.Z) * TGCMatrix.Translation(ship.Position);

            return ship;

        }

        public TgcMesh crearInstanciaM6(string MediaDir)
        {
            TgcSceneLoader loader = new TgcSceneLoader();
            //ship = loader.loadSceneFromFile(MediaDir + "StarWars-Speeder-TgcScene.xml").Meshes[0];
            TgcMesh ship = loader.loadSceneFromFile(MediaDir + "XWing\\m6-TgcScene.xml").Meshes[0];
            // Al XWIN le falta una aleta.
            ship.Effect = TGCShaders.Instance.LoadEffect(MediaDir + "ShipRoll.fx");
            ship.Technique = "Normal";
            ship.Position = new TGCVector3(0, 0, 5);
            ship.Rotation = new TGCVector3(0, /*FastMath.PI / 2*/0, 0);
            ship.Transform = TGCMatrix.Scaling(TGCVector3.One * 10f) * TGCMatrix.RotationYawPitchRoll(ship.Rotation.Y, ship.Rotation.X, ship.Rotation.Z) * TGCMatrix.Translation(ship.Position);

            return ship;

        }
    }
}
