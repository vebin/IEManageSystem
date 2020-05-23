import React from 'react'
import PropTypes from 'prop-types'

import CmsRedux from 'CMSManage/IEReduxs/CmsRedux'
import CreateComponentService from 'CMSManage/Component/ComponentContainers/PageEditCompontContainer/CreateComponentService'

import './PageContainer.css'

import PageEditCompontContainer from 'CMSManage/Component/ComponentContainers/PageEditCompontContainer'

import { pageAddComponent, pageComponentUpdateFetch, pageFetch } from 'CMSManage/IEReduxs/Actions'

import { ieReduxFetch } from 'Core/IEReduxFetch'

import BtnLists from './BtnLists'
import PromptBox from 'PromptBox'
import ComponentListBox from "./ComponentListBox"

class PageContainer extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            // 要将组件添加到那个父组件下，undefined 表示没有父组件
            curParentComponent: undefined,
            showComponentListBox: false,
            isload: false
        }

        this.submitPage = this.submitPage.bind(this);
        this.addComponent = this.addComponent.bind(this);

        this.props.pageFetch(props.pageName)
        .then(value=>{
            this.setState({isload: true});
        });
    }

    submitPage() {
        this.props.pageComponentUpdateFetch(
            this.props.pageName,
            this.props.page.pageComponents
        );
    }

    addComponent(selectedComponentDescribe) {
        if (!selectedComponentDescribe) {
            return;
        }

        let pageComponent = CreateComponentService.createComponent(
            this.props.page.pageComponents,
            selectedComponentDescribe,
            this.state.curParentComponent ? this.state.curParentComponent.sign : null);

        this.props.addComponent(pageComponent);
    }

    render() {
        if(!this.state.isload){
            return <div className="pageedit-page-container"></div>
        }

        let promptBox = (<PromptBox>
            <div className="pageedit-page-container-header-info">
                <div className="input-group shadow-sm">
                    <input value={this.props.page.displayName} type="text" className="form-control" placeholder="" disabled />
                    <div className="input-group-append">
                        <span className="input-group-text text-white">显示名称</span>
                    </div>
                </div>
                <div className="input-group shadow-sm">
                    <input value={this.props.page.name} type="text" className="form-control" placeholder="" disabled />
                    <div className="input-group-append">
                        <span className="input-group-text text-white">
                            <span className="oi oi-key" title="icon name" aria-hidden="true"></span>
                                &#12288;名称
                            </span>
                    </div>
                </div>
                <div className="input-group shadow-sm">
                    <input value={this.props.page.description} type="text" className="form-control" placeholder="" disabled />
                    <div className="input-group-append">
                        <span className="input-group-text text-white">
                            <span className="oi oi-info mr-2" title="icon name" aria-hidden="true"></span>
                                &#12288;描述
                            </span>
                    </div>
                </div>
            </div>
        </PromptBox>);

        return (
            <div className="pageedit-page-container">
                <div className="">
                    <div className="front-page-container">
                        {
                            this.props.childPageComponents.map(item =>
                                <PageEditCompontContainer
                                    key={item.sign}
                                    pageComponent={item}
                                    addChildComponent={(curParentPageComponent)=>{
                                        this.setState({curParentComponent: curParentPageComponent, showComponentListBox: true});
                                    }}
                                >
                                </PageEditCompontContainer>)
                        }
                    </div>
                </div>
                <div className="col-md-12 padding-0 pageedit-page-container-btns">
                    <BtnLists
                        addComponent={()=>{this.setState({curParentComponent: undefined, showComponentListBox: true})}}
                        submitPage={this.submitPage}
                        pageInfoComponent={promptBox}
                        pageUpdate={
                            () => {
                                let myEvent = new Event('resize');
                                window.dispatchEvent(myEvent);
                            }
                        }
                    />
                </div>
                <ComponentListBox
                    show={this.state.showComponentListBox}
                    close={() => { this.setState({ showComponentListBox: false }) }}
                    addComponent={this.addComponent}
                />
            </div>
        );
    }
}

PageContainer.propTypes = {
    page: PropTypes.object,
    pageName: PropTypes.string.isRequired,
    childPageComponents: PropTypes.array.isRequired,
    addComponent: PropTypes.func.isRequired,
    pageComponentUpdateFetch: PropTypes.func.isRequired,
    pageFetch: PropTypes.func.isRequired
}

const mapStateToProps = (state, ownProps) => { // ownProps为当前组件的props
    
    let childPageComponents = state.page.pageComponents.filter(item => !item.parentSign);

    return {
        page: state.page,
        pageName: ownProps.pageName,
        childPageComponents: childPageComponents
    }
}

const mapDispatchToProps = (dispatch, ownProps) => {
    return {
        addComponent: (pageComponent) => {
            dispatch(pageAddComponent(pageComponent));
        },
        pageComponentUpdateFetch: (name, components) => {
            dispatch(pageComponentUpdateFetch(name, components));
        },
        pageFetch: (name) => {
            return dispatch(pageFetch(name));
        }
    }
}

const PageContainerContain = CmsRedux.connect(
    mapStateToProps, // 关于state
    mapDispatchToProps
)(PageContainer)

export default PageContainerContain;