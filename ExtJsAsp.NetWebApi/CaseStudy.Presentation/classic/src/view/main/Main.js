/**
 * This class is the main view for the application. It is specified in app.js as the
 * "mainView" property. That setting automatically applies the "viewport"
 * plugin causing this view to become the body element (i.e., the viewport).
 *
 * TODO - Replace this content of this view to suite the needs of your application.
 */
Ext.define('CaseStudyPresentation.view.main.Main', {
    extend: 'Ext.container.Container',
    xtype: 'app-main',

    requires: [
        'Ext.plugin.Viewport',
        'Ext.window.MessageBox',

        'CaseStudyPresentation.view.main.MainController',
        'CaseStudyPresentation.view.main.MainModel',
        'CaseStudyPresentation.view.main.List'
    ],

    controller: 'main',
    viewModel: 'main',

    items: [{
        xtype: 'tabpanel',
        items: [{
            title: 'Contacts',
            xtype: 'grid',
            id   : 'contactsGrid',
            store: Ext.create('Ext.data.Store', {
                fields: [{
                    name: 'ID',
                    type: 'string'
                }, {
                    name: 'FirstName',
                    type: 'string'
                }, {
                    name: 'LastName',
                    type: 'string'
                }, {
                    name: 'Phone',
                    type: 'string'
                }, {
                    name: 'FullName',
                    type: 'string',
                    convert: function (v, record) {
                        return record.get('FirstName') + ' ' + record.get('LastName');
                    }
                }
                ]
            }),
            columns: [
                { text: 'FirstName', dataIndex: 'FirstName' },
                { text: 'LastName', dataIndex: 'LastName' },
                { text: 'Phone', dataIndex: 'Phone' },
                { text: 'FullName', dataIndex: 'FullName' },
                {
                    text: 'Test', dataIndex: 'FullName', renderer: function (v, record) {
                        return record.get('FullName') + 'ddddddddddddd';
                    }
                }],
            listeners: {
                boxready: function (component) {
                    Ext.Ajax.request({
                        url: 'http://localhost/CaseStudy.AppService/api/Contact',

                        success: function (response, opts) {
                            var obj = Ext.decode(response.responseText);

                            component.getStore().loadData(obj);
                        },

                        failure: function (response, opts) {
                            console.log('server-side failure with status code ' + response.status);
                        }
                    });
                },
                itemdblclick: function (grid, record) {
                    alert(record.get('ID'));
                }
            }
        }, {
            title: 'Contact',
            xtype: 'container',
            html: 'ssssssssssss'
        }]
    }]

});
