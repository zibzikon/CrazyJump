using System.Collections.Generic;
using System.Linq;
using Kernel.ECSIntegration;
using Kernel.GamePlay;
using Kernel.GamePlay.GameBoard;
using Kernel.GamePlay.GameBoard.Interfaces;
using Kernel.GamePlay.GameBoardEndPart;
using Kernel.GamePlay.HeightsDiapason;
using Kernel.GamePlay.PlayerCharacter;
using Kernel.GamePlay.ValuePanel;
using Kernel.GamePlay.ValuePanel.Interfaces;
using Kernel.Mediators;
using Kernel.Services;
using Kernel.Systems.Registration;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;
using EntityViewFactory = Kernel.Services.EntityViewFactory;

namespace Kernel.Installers
{
    public class GamePlayInstaller : MonoInstaller
    {
        [Required, SerializeField] private Engine _engine;
        [Required, SerializeField] private Mediator _mediator;
        [SerializeField] private List<GameBoardChunkConfiguration> _gameBoardChunksConfigurations;
        [SerializeField] private ViewsResourcesData _viewsResourcesData;
        
        public override void InstallBindings()
        {
            var contexts = Contexts.sharedInstance;

            Container.BindInstance(contexts);
            Container.BindInstance(contexts.game);
            Container.BindInstance(contexts.level);
            Container.BindInstance(contexts.input);
            
            Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
            Container.Bind<IEntityIdentifierGenerator>().To<EntityIdentifierGenerator>().AsSingle();
            
            Container.Bind<IViewsProvider>().To<ViewsProvider>().AsSingle().WithArguments(_viewsResourcesData);

            Container.Bind<IMediator>().FromInstance(_mediator);
            
            Container.Bind<IGameBoardGenerator>().To<RandomGameBoardGenerator>().AsSingle().WithArguments(_gameBoardChunksConfigurations.ToArray());
            Container.Bind<IGameBoardViewFactory>().To<GameBoardViewFactory>().AsSingle();
            Container.Bind<IHeightsDiapasonRowViewFactory>().To<HeightsDiapasonRowViewFactory>().AsSingle();
            
            Container.Bind<IGameBoardEndPartViewFactory>().To<GameBoardEndPartViewFactory>().AsSingle();
        
            Container.Bind<IValuePanelViewFactory>().To<ValuePanelViewFactory>().AsSingle();
            
            Container.Bind<IPlayerCharacterViewFactory>().To<PlayerCharacterViewFactory>().AsSingle();
           
            Container.Bind<IGameEntityCreator>().To<GameEntityCreator>().AsSingle();
            Container.Bind<GameSystems>().ToSelf().AsSingle();
            
            Container.BindInstance(_engine);
        }
        
    }
}